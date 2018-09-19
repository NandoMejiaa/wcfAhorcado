using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WsAhorcado
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSAhorcado : IWSAhorcado
    {
        
        public Palabra ObtenerPalabra()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string[] wordBank = { "PILSENER", "SUPREMA", "GALLO", "GOLDEN", "MILLER" };

            string wordToGuess = wordBank[random.Next(0, wordBank.Length)];
            string wordToGuessUppercase = wordToGuess.ToUpper();

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                displayToPlayer.Append('-');
            }

            return new Palabra() {
                    nuevaPalabra = wordToGuessUppercase,
                    nuevaPalabraGuion  = displayToPlayer.ToString(),
                    vidasRestantes = 7.ToString(),
            };
        }


        public Palabra ValidarLetra(string Letra, string Palabra, string PalabraGuion, string VidasRestantes)
        {


            string wordToGuess = Palabra;
            string wordToGuessUppercase = wordToGuess.ToUpper();
            string palabraGuion = PalabraGuion;
            int lives = int.Parse(VidasRestantes);
            string mensaje = "";

            bool won = false;

            string input = Letra.ToUpper(); 
            char guess = input[0];

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            displayToPlayer.Append(palabraGuion);

            if (!won && lives > 0)
            {

                if (wordToGuessUppercase.Contains(guess))
                {

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuessUppercase[i] == guess)
                        {
                            displayToPlayer[i] = wordToGuess[i];
                        }
                    }

                    if (displayToPlayer.ToString().Equals(wordToGuessUppercase.ToString()))
                    {
                        won = true;
                        mensaje = "¡¡FELICIDADES!! Has Ganado!!, Presiona Nueva Palabra para Continuar";
                    }

                }
                else
                {
                    lives--;
                    if (lives == 0)
                    {
                        mensaje = "No!!, No Hay " + guess + " en la Palabra, Has Perdido el Juego, Presiona Nueva Palabra para Continuar";
                    }
                    else
                    {
                        mensaje = "No!!, No Hay " + guess + " en la Palabra";
                    }

                }

            }

            return new Palabra()
                {
                    nuevaPalabra = wordToGuessUppercase,
                    nuevaPalabraGuion = displayToPlayer.ToString(),
                    vidasRestantes = lives.ToString(),
                    mensaje = mensaje.ToString()
                };

            
        }
       
    }
}
