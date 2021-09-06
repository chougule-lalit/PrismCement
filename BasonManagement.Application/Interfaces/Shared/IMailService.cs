using BasonManagement.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace BasonManagement.Application.Interfaces.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}