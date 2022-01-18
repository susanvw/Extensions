using SvwDesign.Extensions.Interfaces;
using System;

namespace SvwDesign.Extensions.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
