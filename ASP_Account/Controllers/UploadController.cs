using Microsoft.AspNetCore.Mvc;

namespace ASP_Account.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFileAsync(IFormFile file)
        {
            if (file.Length > 0)
            {
                var filePath = $".//www//Files//{new FileInfo(Path.GetRandomFileName() + file.FileName)}";

                using (var stream = System.IO.File.Create(filePath))
                {
                    await file.CopyToAsync(stream);
                }

            }

            return Ok(new { file });

        }

        [HttpGet("GetAllFiles")]
        public IEnumerable<string> GetAllFiles()
        {
            string path = ".//www//Files//";
            return new DirectoryInfo(path).GetFiles().Select(f => f.Name);
        }

        [HttpGet("GetFileName")]
        public IEnumerable<string> GetFileName(string fileName)
        {
            var result = Path.GetFileName(fileName);
            yield return result;
        }



        [HttpGet("GetTimeFiles")]
        public IEnumerable<string> GetTimeFiles(DateTime date)
        {
            string[] fileArry = Directory.GetFiles(".//www//Files//").OrderBy(p => new FileInfo(p).CreationTime == date).ToArray();
            return fileArry;

        }






    }
}
