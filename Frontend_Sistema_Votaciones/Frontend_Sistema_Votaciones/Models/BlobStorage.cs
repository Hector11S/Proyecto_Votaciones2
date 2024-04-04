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
        private readonly AppSettings _appSettings;
        public BlobStorage(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            containerClient = new BlobContainerClient(_appSettings.AzureBlobStorageAddress, "main");
        }

        public async Task<Azure.Response<BlobContentInfo>> UploadFromBinaryDataAsync(
            //BlobContainerClient containerClient,
            string localFilePath)
        {
            string fileName = Path.GetFileName(localFilePath);
            BlobClient blobClient = containerClient.GetBlobClient(fileName);

            FileStream fileStream = File.OpenRead(localFilePath);
            BinaryReader reader = new BinaryReader(fileStream);

            byte[] buffer = new byte[fileStream.Length];
            reader.Read(buffer, 0, buffer.Length);
            BinaryData binaryData = new BinaryData(buffer);
            Azure.Response<BlobContentInfo> response = await blobClient.UploadAsync(binaryData, true);
            
            fileStream.Close();
            return response;
        }
    }
}
