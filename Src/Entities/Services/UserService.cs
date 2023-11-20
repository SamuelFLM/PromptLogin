using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Newtonsoft.Json;
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
            _url = "http://localhost:5255/v1/user";
        }

        public async Task<IEnumerable<User>> ObterTodos()
        {
            try
            {
                var response = await _http.GetAsync(_url);

                string jsonString = await response.Content.ReadAsStringAsync();

                List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonString);

                return users;
            }
            catch (Exception ex)
            {
                Console.WriteLine("OCORREU ALGUM ERRO AO CONSULTAR. POR FAVOR, VERIFIQUE SE ESTÁ CORRETO", ex);
            }
            return null;
        }

        public async Task<User> ObterPorId(int id)
        {
            try
            {
                var response = await _http.GetAsync($"{_url}/{id}");
                string jsonString = await response.Content.ReadAsStringAsync();

                User objJson = JsonConvert.DeserializeObject<User>(jsonString);

                return objJson;
            }
            catch (Exception ex)
            {
                Console.WriteLine("OCORREU ALGUM ERRO AO CONSULTAR. POR FAVOR, VERIFIQUE SE ESTÁ CORRETO", ex);
            }
            return null;
        }

        public async Task<User> Criar(User user)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await _http.PostAsync(_url, content);

                string responseString = await response.Content.ReadAsStringAsync();

                User objJson = JsonConvert.DeserializeObject<User>(responseString);

                return objJson;
            }
            catch (Exception ex)
            {
                Console.WriteLine("OCORREU ALGUM ERRO AO CONSULTAR. POR FAVOR, VERIFIQUE SE ESTÁ CORRETO", ex);
            }
            return null;
        }

        public async Task<User> Atualizar(User user)
        {
            try
            {
                string jsonString = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                var response = await _http.PutAsync($"{_url}/{user.Id}", content);
                var responseString = await response.Content.ReadAsStringAsync();

                var objJson = JsonConvert.DeserializeObject<User>(responseString);

                return objJson;
            }
            catch (Exception ex)
            {
                Console.WriteLine("OCORREU ALGUM ERRO AO CONSULTAR. POR FAVOR, VERIFIQUE SE ESTÁ CORRETO", ex);
            }
            return null;
        }

        public async Task<bool> Deletar(int id)
        {
            try
            {
                var response = await _http.DeleteAsync($"{_url}/{id}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("OCORREU ALGUM ERRO AO EXCLUIR. POR FAVOR, VERIFIQUE SE ESTÁ CORRETO");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("OCORREU ALGUM ERRO AO EXCLUIR. POR FAVOR, VERIFIQUE SE ESTÁ CORRETO", ex);
                return false;
            }
        }
    }
}