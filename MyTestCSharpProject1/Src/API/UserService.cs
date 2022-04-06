using System;
using System.Threading;
using System.Threading.Tasks;
using MyTestCSharpProject1.Src.Dto;
using MyTestCSharpProject1.Src.Dto.UserDTO.UserRequestDTO;

namespace MyTestCSharpProject1.Src.API
{
    public class UserService
    {

        private ApiClient apiClient;

        public UserService()
        {
            apiClient = new ApiClient();
        }

        public GetUserListResponseDTO GetUser(int pageNumber)
        {
            var request = apiClient.CreateGetRequest($"/api/users?page={pageNumber}");
            var response = apiClient.GetResponse(request);
            var content = apiClient.GetContent<GetUserListResponseDTO>(response);

            return content;
        }

        public PostCreateUserResponseDTO CreateUser(string name, string job)
        {
            var payload = new PostCreateUserRequestDTO() { Name = name, Job = job, };

            var request = apiClient.CreatePostRequest("/api/users", payload);
            var response = apiClient.GetResponse(request);
            var content = apiClient.GetContent<PostCreateUserResponseDTO>(response);

            return content;
        }

        public async Task<PostCreateUserResponseDTO> CreateUserAsync(string name, string job) //
        {
            Thread.Sleep(10000);

            var payload = new PostCreateUserRequestDTO() { Name = name, Job = job, };

            var request = apiClient.CreatePostRequest("/api/users", payload);
            var response = await apiClient.GetResponseAsync(request);
            var content = apiClient.GetContent<PostCreateUserResponseDTO>(response);

            return content;
        }

        public async Task<PostCreateUserResponseDTO> CreateUserAsync2(string name, string job) //
        {

            var payload = new PostCreateUserRequestDTO() { Name = name, Job = job, };

            var request = apiClient.CreatePostRequest("/api/users", payload);
            var response = await apiClient.GetResponseAsync(request);
            var content = apiClient.GetContent<PostCreateUserResponseDTO>(response);

            return content;
        }
    }
}
