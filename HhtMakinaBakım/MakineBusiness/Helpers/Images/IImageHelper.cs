using MakineEntity.DTOs.Images;
using MakineEntity.Enums;
using Microsoft.AspNetCore.Http;

namespace MakineBussines.Helpers.Images
{
	public interface IImageHelper
    {
        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile,ImageType imageType, string folderName = null);
        void Delete(string imageName);
    }
}
