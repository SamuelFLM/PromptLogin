using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Src.Entities;

namespace Src.Entities.Services
{
    public class UserService
    {
        private readonly HttpClient _http;
        private readonly string _url;

        public UserService()
        {
            _http = new HttpClient();
            _url = "http://localhost:5255/v1/user"
        }

        public async Task<User> ObterTodos()
        {
            try
            {
                var response = await _http.GetAsync($"{_url}{cep}/json");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

            return null;
        }
    }
}