using System;

namespace CursoFoop_SRP_Aderente
{
    class EnviarEmail
    {
        private Ilogger infoLogger;

        public EnviarEmail()
        {
            infoLogger = new RegistraLog();
        }


        public string EMailFrom { get; set; }
        public string EMailTo { get; set; }
        public string EMailSubject { get; set; }
        public string EMailBody { get; set; }
        public void Enviar()
        {

            try
            {
                infoLogger.Info("Enviando e-mail");


                //....

                infoLogger.Info("E-mail enviado");

            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro ao enviar o e-mail : " + ex.Message);
            }
        }
    }
}
