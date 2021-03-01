﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IESA.Models
{
    public class Orgenaizers
    {
        int userid; //Automatic
        string email;
        string password1;
        string nickname;
        string firstname;
        string lastname;
        string gender;
        int id; //Passport id
        string phone;
        DateTime dob;
        string address1;
        string discorduser;
        string picture;
        string comunityname;
        string linktocommunity;
        int status1; //0 or 1

        public Orgenaizers(int userid, string email, string password1, string nickname, string firstname, string lastname, string gender, int id, string phone, DateTime dob, string address1, string discorduser, string picture, string comunityname, string linktocommunity, int status1)
        {
            Userid = userid;
            Email = email;
            Password1 = password1;
            Nickname = nickname;
            Firstname = firstname;
            Lastname = lastname;
            Gender = gender;
            Id = id;
            Phone = phone;
            Dob = dob;
            Address1 = address1;
            Discorduser = discorduser;
            Picture = picture;
            Comunityname = comunityname;
            Linktocommunity = linktocommunity;
            Status1 = status1;
        }

        public Orgenaizers() { }

        public int Userid { get => userid; set => userid = value; }
        public string Email { get => email; set => email = value; }
        public string Password1 { get => password1; set => password1 = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Id { get => id; set => id = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Address1 { get => address1; set => address1 = value; }
        public string Discorduser { get => discorduser; set => discorduser = value; }
        public string Picture { get => picture; set => picture = value; }
        public string Comunityname { get => comunityname; set => comunityname = value; }
        public string Linktocommunity { get => linktocommunity; set => linktocommunity = value; }
        public int Status1 { get => status1; set => status1 = value; }


        //#Functions Area










    }
}