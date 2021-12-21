using System;
using System.Threading.Tasks;
using Valid.WSQ.Services.Contracts;
using Valid.WSQ.Services;
using Valid.Logging.Infrastructure.Services;
using System.Drawing;

namespace Atividade_OperacoesImagens.Componentes
{
    public class ConversoesImagem
    {
        public static Byte[] WSQParaByteArray(Byte[] wsq, System.Drawing.Imaging.ImageFormat formato)
        {
            try
            {
                var log = new NLogLoggingService();
                IWSQ objWSQ = new MultiThreadWSQ(log);

                //Descompacta WSQ para o formato escolhido
                var task = Task.Run(() => objWSQ.ExtractWSQToImageByteArray(wsq, formato));
                task.Wait();
                return task.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Byte[] ByteArrayParaWSQ(Byte[] imagem, System.Drawing.Imaging.ImageFormat formato)
        {
            try
            {
                var log = new NLogLoggingService();
                IWSQ objWSQ = new MultiThreadWSQ(log);

                //Compacto o Array de Bytes para WSQ
                var task = Task.Run(() => objWSQ.GenerateWSQFromImage(imagem));
                task.Wait();
                return task.Result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Byte[] ImagemParaWSQ(Image imagem, System.Drawing.Imaging.ImageFormat formato = null)
        {
            try
            {
                var log = new NLogLoggingService();
                IWSQ objWSQ = new MultiThreadWSQ(log);

                //Compacto o Array de Bytes para WSQ
                var task = Task.Run(() => objWSQ.GenerateWSQFromImage(imagem));
                task.Wait();
                return task.Result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}