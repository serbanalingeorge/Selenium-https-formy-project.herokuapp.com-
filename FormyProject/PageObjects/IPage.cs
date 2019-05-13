using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FormyProject.PageObjects
{
    public interface IPage
    {
        bool IsAt();
        void GoTo();
        
    }
}
