using System;

namespace Passenger.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public string Username { get; protected set; }
        public string Fullname { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; protected set; }

        protected User()
        {
        }

        public User(string email, string username, 
                string password, string salt)
        {
            Id = Guid.NewGuid();
            SetEmail(email.ToLowerInvariant());
            SetUsername(username);
            SetPassword(password);
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }

        public void SetUsername(string username)
        {
            if(string.IsNullOrWhiteSpace(username))
            {
                throw new Exception("Username cannot be null or white space.");
            }

            Username = username;
            UpdatedAt = DateTime.Now;
        }
        public void SetEmail(string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email cannot be null or white space.");
            }

            Email = email;
            UpdatedAt = DateTime.Now;
        }
        public void SetPassword(string password)
        {
            if(string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password cannot be null or white space.");
            }
            if(password.Length < 4)
            {
                throw new Exception("Password must be longer than 3 letters.");
            }
            if(password.Length > 100)
            {
                throw new Exception("Password must be shorter or equal to 100 letters.");
            }

            Password = password;
            UpdatedAt = DateTime.Now;
        }
    }
}