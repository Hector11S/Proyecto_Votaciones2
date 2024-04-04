using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
//using Azure.Identity;

namespace Frontend_Sistema_Votaciones.Models
{
    public class BlobStorage
    {
        private readonly BlobContainerClient containerClient;
        private readonly IHttpContextAccessor _httpContext;
        private readonly AppSettings _appSettings;
        public BlobStorage(IHttpContextAccessor httpContext, IOptions<AppSettings> appSettings)
        {
            _httpContext = httpContext;
            _appSettings = appSettings.Value;
            containerClient = new BlobContainerClient(_appSettings.AzureBlobStorageConnectionString, "main");
        }

        public async Task<Azure.Response<BlobContentInfo>> SubirImagen(string localFilePath)
        {
            string fileName = Path.GetFileName(localFilePath);
            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            Azure.Response<BlobContentInfo> response = await blobClient.UploadAsync(localFilePath, true);
            return response;
        }
        public string ObtenerUrlImagen(string localFilePath)
        {
            var fileName = Path.GetFileName(localFilePath);
            return containerClient.Uri + "/" + fileName;
        }
    }
}
