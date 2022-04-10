using System;
using System.Net.Mail;
using MailTAsk;
namespace MailTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pls enter Mail Adress");
                string mail = Console.ReadLine();
                MailAddress mailAddress = new MailAddress(mail);
                Console.WriteLine("Pls enter  Title");
                string title = Console.ReadLine();
                if (title.Length > 100 && title == null)
                {
                    throw new MailTitleNotValidException("may be title is null or tooooooo long");
                }
                Console.WriteLine("pls enter message");
                string message = Console.ReadLine();
                if (message.Length == 0)
                {
                    throw new MailMessageNotValidException("empty message");
                }

                MailSender.SendMail(mail, title, message);
                Console.WriteLine("Mail sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
    }
}




/*Tapşırıq 3:
Static bir MailSender classınız olsun. Bu classın SendMail metodu olsun. Bu metod Email, Title, Message arqumentləri qəbul edir. Email məktubun göndəriləcəyi adresi ifadə edir. 
Console app istifadəçidən hər üç arqumenti almalı (ReadLine) və SendMail metoduna göndərməlidir.
SendMail metodu çağırılanda Email-in valid-liyi yoxlanılır əgər valid deyilsə exception throw olunur. (MailAddress classından istidfadə edin.)
Title boş olarsa və ya uzunluğu 100-dən çox olarsa sizin yaradacağınız MailTitleNotValidException-unu throw eləsin.
Message boş olarsa sizin yaradacağınız MailMessageNotValidException-unu throw eləsin.
Bu exception-lar Program.cs-də catch olunmalı, isitfaçiyə exception message göstərilməlidir.
Bu metod faktiki olaraq arqumentləri yoxlamaqdan başqa iş görmür, yəni mailin doğurdan göndərilməsi tələb olunmur.
Sadəcə metod heç bir exception-a düşməzsə sonda console-a "Mail sent successfully." yazılsın.
Bonus: mail doğurdan göndərilsin. Boş vaxtı və həvəsi 
olanlar https://gist.github.com/bashirazizov/0327b06a62550d88aa3aaf4c68bb1148 bu linkdəki koda baxıb yaza bilərlər. 
Kor koranə copy paste etməyin, işləməyəcək. Kodu oxumağa çalışın lazımı variable-ları dəyişin. Elə də çətin deyil. Sual olarsa verə bilərsiniz.*/