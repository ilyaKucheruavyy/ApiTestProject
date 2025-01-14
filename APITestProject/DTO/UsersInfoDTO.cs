﻿using Newtonsoft.Json;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace APITestProject.DTO
{
    public class UsersInfoDTO
    {
        [JsonProperty("first_name")] public string FirstName { get; set; }

        [JsonProperty("last_name")] public string LastName { get; set; }

        [JsonProperty("id")] public string ID { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("job")] public string Job { get; set; }

        [JsonProperty("password")] public string Password { get; set; }

        [JsonProperty("token")] public string Token { get; set; }

        [JsonProperty("avatar")] public string Avatar { get; set; }

        [JsonProperty("data")] public UsersInfoDTO DataAboutUser { get; set; }

        public override bool Equals(object obj) => this.Equals(obj as UsersInfoDTO);

        public bool Equals(UsersInfoDTO obj)
        {
            Assert.IsNotEmpty(obj.ID, "ID field is empty");
            Assert.AreEqual(this.Email, obj.Email, "Incorrect email");
            Assert.AreEqual(this.Name, obj.Name, "Incorrect name");
            Assert.AreEqual(this.Job, obj.Job, "Incorrect job");
            Assert.AreEqual(this.Password, obj.Password, "Incorrect password");
            Assert.AreEqual(this.Token, obj.Token, "Incorrect Token");
            Assert.AreEqual(this.FirstName, obj.FirstName, "Incorrect first name");
            Assert.AreEqual(this.LastName, obj.LastName, "Incorrect last name");
            Assert.IsNotEmpty(obj.Avatar, "Avatar field is empty");

            return true;
        }

        public UsersInfoDTO DataAboutSingleUser(Table table)
        {
            var data = table.CreateInstance<UsersInfoDTO>();
            this.DataAboutUser = data;
            return this;
        }
    }
}
