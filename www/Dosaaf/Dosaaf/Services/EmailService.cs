using System.Net;
using System.Net.Mail;

namespace Dosaaf.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            MailAddress from = new MailAddress("fykpqmz@yandex.ru", "Гайская автошкола ДОСААФ");
            MailAddress to = new MailAddress(email);
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Вы успешно записались на обучение!";
            message.Body = @"<style>
            @font-face {
                font-family: 'Montserrat-Regular';
                src: url(../font/Montserrat-Regular.ttf);
            }

            @font-face {
                font-family: 'Montserrat-Bold';
                src: url(../font/Montserrat-Bold.ttf);
            }
            #record-education-main-section {
                display: flex;
                flex-direction: column;
            }
            #record-education-section h1 {
                font-family: Montserrat-Bold;
            }

            #record-education-section p {
                font-family: Montserrat-Regular;
            }

            #record-education-section {
                display: flex;
                justify-content: space-between;
                flex-direction: row;
                background: #D9D9D9;
                padding: 130px 130px 120px 120px;
            }
            </style>
            <div id='record-education-main-section'>
                <div id='record-education-section'>
                    <div id='online-education-left-section'>
                        <h1>Спасибо за заявку</h1>
                        <p> Вы успешно записаны.</p>
                    </div>
                </div>
            </div> ";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("fykpqmz", "nenvtynrpphpgajn");
            smtp.EnableSsl = true;
            smtp.Send(message);

        }
    }
}
