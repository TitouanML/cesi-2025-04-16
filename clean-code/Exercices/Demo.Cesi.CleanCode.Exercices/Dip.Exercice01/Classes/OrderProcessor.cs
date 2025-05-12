namespace Dip.Exercice01.Classes
{
    public class OrderProcessor
    {
        private IEmailService _emailService;

        public OrderProcessor(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Process()
        {
            // Traitement de la commande...
            _emailService.sendEmail("Commande traitée.");
        }
    }

}
