using System;
using System.Threading.Tasks;
using Valid.WSQ.Services.Contracts;
using Valid.WSQ.Services;
using Valid.Logging.Infrastructure.Services;
using System.Drawing;
using System.Drawing.Imaging;

namespace Atividade_OperacoesImagens.Componentes
{
    public class ConversoesImagem
    {
        public static byte[] WSQParaByteArray(byte[] wsq, ImageFormat formato)
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

        public static Image WSQParaImagem(byte[] wsq, ImageFormat formato)
        {
            try
            {
                var log = new NLogLoggingService();
                IWSQ objWSQ = new MultiThreadWSQ(log);

                //Descompacta WSQ para o formato escolhido
                var task = Task.Run(() => objWSQ.ExtractWSQToImage(wsq, formato));
                task.Wait();
                return task.Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static byte[] ByteArrayParaWSQ(byte[] imagem)
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