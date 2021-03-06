﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Infrastructure
{
    public class RoleProvider : System.Web.Security.RoleProvider
    {

        // Authorization! - invoke by default by .net
        public override string[] GetRolesForUser(string username)
        {
            // check for who is allowed to what or return empty
            if(username == "admin")
                return new[] {"admin"};

            return new string[] {};
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            // keep all of them since we don't wnat them getinvoke now
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string ApplicationName { get; set; }
    }
}