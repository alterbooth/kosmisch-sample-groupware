using System.Net.Mail;
using System.Text;

namespace Kosmisch.Sample.OnPremisesAspnetApp.Helpers
{
    public static class EmailHelper
    {
        public static void Send(string Address, string Subject, string Body)
        {
            // 各種設定値はサンプルのため、実際には動作しません
            var client = new SmtpClient("smtp.kosmischsample.net");
            var from = new MailAddress("from@kosmischsample.net", "Kosmisch", Encoding.UTF8);
            var to = new MailAddress(Address);
            var message = new MailMessage(from, to);
            message.Body = Body;
            message.BodyEncoding = Encoding.UTF8;
            message.Subject = Subject;
            message.SubjectEncoding = Encoding.UTF8;
            client.Send(message);
            message.Dispose();
        }
    }
}