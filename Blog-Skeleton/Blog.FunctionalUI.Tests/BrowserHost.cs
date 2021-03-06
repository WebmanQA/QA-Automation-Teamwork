﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.FunctionalUI.Tests
{
    public class BrowserHost
    {
        public static readonly SelenoHost Instance = new SelenoHost();
        public static readonly string RootUrl = @"http://localhost:60634/Article/List";

        static BrowserHost()
        {

            Instance.Run("Blog", 60639, w => w.WithRemoteWebDriver(() => new ChromeDriver()));
        }
    }
}
