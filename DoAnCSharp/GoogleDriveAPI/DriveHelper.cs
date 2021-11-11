using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DoAnCSharp.GoogleDriveAPI
{
    public static class DriveHelper
    {
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive API .NET Quickstart";
        static private UserCredential credential = ReadCreadential();
        
        public static string GetAccessToken()
        {
            return credential.Token.AccessToken;
        }
        
        // Create Drive API service.
        public static DriveService service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = ApplicationName,
        });

        private static UserCredential ReadCreadential()
        {
            UserCredential cre;
            using (var stream =
                new FileStream("./GoogleDriveAPI/credentials.json", FileMode.Open, FileAccess.Read))
            {          
                string credPath = "token.json";
                cre = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }
            return cre;
        }

        public static List<Google.Apis.Drive.v3.Data.File> GetFilesInFloder(string floder_id)
        {
            // Define parameters of request.
            string pageToken = null;
            FilesResource.ListRequest listRequest = service.Files.List();
            var driveFiles = new List<Google.Apis.Drive.v3.Data.File>();
            do
            {
                listRequest.Fields = "nextPageToken, files(id,name,webContentLink)";
                listRequest.Q = $"parents = '{floder_id}'";
                listRequest.PageToken = pageToken;
                Google.Apis.Drive.v3.Data.FileList reponse = listRequest.Execute();
                foreach (var item in reponse.Files)
                    driveFiles.Add(item);
                pageToken = reponse.NextPageToken;
            } while (!string.IsNullOrEmpty(pageToken));
            return driveFiles;
        }
    }
}
