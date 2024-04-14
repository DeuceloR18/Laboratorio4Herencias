using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

public interface INotificable
{
    void Notifica();
}

public class NotificacionEmail : INotificable
{
    public string DireccionCorreo { get; set; }

    public void Notifica()
    {
        Console.WriteLine("Enviando notificación por correo electrónico a: {DireccionCorreo}");
        Console.WriteLine("Hola mundo");
    }
}

public class NotificacionWhatsap : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notifica()
    {
        Console.WriteLine("Enviando notificación por WhatsApp al número: 34219087");
        Console.WriteLine("Este es mi programa");
    }
}

public class NotificacionSMS : INotificable
{
    public string NumeroTelefono { get; set; }

    public void Notifica()
    {
        Console.WriteLine($"Enviando notificación por SMS al número: 34219087");
        Console.WriteLine("Este es mi programa");
    }
}

class Program
{
    static void Main()
    {
        var emailNotificacion = new NotificacionEmail { DireccionCorreo = "ucelodani021.com" };
        var whatsappNotificacion = new NotificacionWhatsap { NumeroTelefono = "34219087" };
        var smsNotificacion = new NotificacionSMS { NumeroTelefono = "53746026" };

        emailNotificacion.Notifica();
        whatsappNotificacion.Notifica();
        smsNotificacion.Notifica();
        Console.ReadKey();
    }
}
