using BenjaminCamacho.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BenjaminCamacho.Services
{
    public interface IEmailSender
    {

        Task SendEmailAsync(string email, string v1, string v2);
    }
}