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
            message.Body = @"
            <!DOCTYPE html PUBLIC '-//W3C//DTD HTML 4.01 Transitional//EN' 'http://www.w3.org/TR/html4/loose.dtd'>
            <html>
                <head>
                    <meta http-equiv='Content-type' content='text/html; charset=utf-8'/>
                </head>
                <body style='margin: 0; padding: 0;'>
                    <table style='border: collapse; border: 1px; width: 600px; align-items: center; display: flex; flex-direction: column; border-radius: 15px;'>
                        <tr style='border: collapse; border: 1px; width: 600px; align-items: center; display: flex; flex-direction: column;'>
                            <td align='center' style='padding: 20px 0px;'>
                                <img width='100px' style='display: block;' alt='Автошкола ДОСААФ.'
                                 src='https://sun9-86.userapi.com/impg/Mti_3QD7hsKJ9snipZgEAhsdiEJqzfbOIkwYnQ/y9FgkhPEUPU.jpg?size=512x512&quality=96&sign=a0c288aea1a7ef99fac7971433219715&type=album'/>
                                <h1 style='font-family: Montserrat; font-weight: bold;'>Автошкола ДОСААФ</h1>
                            </td>
                            <td style='background: #D9D9D9; border-radius: 15px; padding: 30px;'>
                                <h2 style='font-family: Montserrat; font-weight: bold;'>Спасибо за заявку на обучение!</h2>
                                <p style='font-family: Montserrat;'>
                                    Вы успешно записались на обучение в 
                                    <b style='color: #DE2339;'>Учебный Центр Гайского ДОСААФ</b>.
                                     Мы рассмотрим вашу заявку и уведомим вас, когда вы можете приступать к обучению
                                </p>
                                <p style='font-family: Montserrat;'>
                                    Если у вас остались вопросы, можете обратиться к нам по почте 
                                    <b>gaidosaaf@mail.ru</b>, либо же позвонить по номеру: 
                                    <b>+ 7 352-624-23-44</b>
                                </p>
                                <p style='font-family: Montserrat;'>
                                    С уважением, Автошкола ДОСААФ
                                    <br/>+ 7 352-624-23-44
                                </p>
                            </td>
                        </tr>
                    </table>
                </body>
            </html>";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 587);
            smtp.Credentials = new NetworkCredential("fykpqmz", "nenvtynrpphpgajn");
            smtp.EnableSsl = true;
            smtp.Send(message);

        }
    }
}
