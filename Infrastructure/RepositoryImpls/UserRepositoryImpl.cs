using System;
using System.Collections.Generic;
using System.Linq;
using com.VKB.AutoInject.Locators;
using Infrastructure.Models;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.RepositoryImpls
{
    [Inject(typeof(IUserRepository))]
    public class UserRepositoryImpl : IUserRepository
    {
        private readonly DatabaseContext _context;
        private readonly DbSet<User> _users;

        public UserRepositoryImpl(DatabaseContext context)
        {
            _context = context;
            _users = _context.Set<User>();
        }

        public IEnumerable<User> GetAll()
        {
            return _users.AsEnumerable();
        }

        public User Find(int id)
        {
            return _users.SingleOrDefault(u=>u.Id == id);
        }

        public void Create(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            _users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            _users.Remove(user);
            _context.SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}