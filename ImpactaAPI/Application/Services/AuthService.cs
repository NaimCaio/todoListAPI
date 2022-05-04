using ImpactaAPI.Models;
using ImpactaAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Application.Services
{

    public class AuthService : IAuthService
    {
        private readonly IRepository<User> _userRepository;
        public readonly Hash hash;
        public AuthService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
            hash = new Hash();
        }
        public User AddUser(User user)
        {
            var accountExists = _userRepository.FirstOrDeafault(a => a.email == user.email) != null;
            if (accountExists)
            {
                throw new Exception("E-mail já cadastrado");
            }
            try
            {
                user.senha = hash.HashPassowrd(user.senha);
                _userRepository.Add(user);
                _userRepository.Save();
                return user;

            }
            catch (Exception)
            {

                throw new Exception("Erro ao salvar novo usuário");
            }
            
        }

        public User AutheticateUser(User user)
        {
            var baseAccount = _userRepository.FirstOrDeafault(a => a.email == user.email);
            if (baseAccount == null)
            {
                throw new Exception("E-mail não cadastrado");
            }

            var authenticate = hash.ValidateUser(user.senha, baseAccount.senha);
            if (authenticate == false)
            {
                throw new Exception("Senha incorreta");
            }
            return user;
        }

        public User DeleteUser(string userEmail)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
