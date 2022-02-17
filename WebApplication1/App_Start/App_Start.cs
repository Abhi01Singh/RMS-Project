//// -----------------------------------------------------------------------
//// <copyright file="App_Start.cs" company="Fluent.Infrastructure">
////     Copyright © Fluent.Infrastructure. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
/// See more at: https://github.com/dn32/Fluent.Infrastructure/wiki
////-----------------------------------------------------------------------

using Fluent.Infrastructure.FluentTools;
using WebApplication1.DataBase;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(WebApplication1.App_Start), "PreStart")]

namespace WebApplication1 {
    public static class App_Start {
        public static void PreStart() {
            FluentStartup.Initialize(typeof(DbContextLocal));
        }
    }
}