using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;

namespace ParamOS
{
    public class Kernel: Sys.Kernel
    {
        Canvas canvas;
        protected override void BeforeRun()
        {
            Console.WriteLine("ParamOS v1.1 booted successfully. Type 'namaste' for greetings, 'about' to learn more about ParamOS, 'gui' to load the graphical user interface, 'restart' to reboot the operating system, and 'shutdown' to shut down the computer.");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            if (input == "namaste")
            {
                Console.WriteLine("Namaste! Nice to meet you! Thank you for using ParamOS!");

            }
            else if (input == "about")
            {
                Console.WriteLine("This is ParamOS v1.1. This operating system was created by Sehej Kaw (Paramarsh Informatics) on 23-October-2023 in India. The intended use of this OS is for learning purpose.");

            }
            else if (input == "shutdown")
            {
                Sys.Power.Shutdown();

            }
            else if (input == "restart")
            {
                Sys.Power.Reboot();

            }
            else if (input == "gui")
            {
                canvas = FullScreenCanvas.GetFullScreenCanvas();

                canvas.Clear(Color.Blue);

                try
                {

                    Pen pen = new Pen(Color.Red);
                    canvas.DrawPoint(pen, 69, 69);


                    pen.Color = Color.GreenYellow;
                    canvas.DrawLine(pen, 250, 100, 400, 100);


                    pen.Color = Color.IndianRed;
                    canvas.DrawLine(pen, 350, 150, 350, 250);


                    pen.Color = Color.MintCream;
                    canvas.DrawLine(pen, 250, 150, 400, 250);


                    pen.Color = Color.PaleVioletRed;
                    canvas.DrawRectangle(pen, 350, 350, 80, 60);

                    Console.ReadKey();


                    canvas.Mode = new Mode(800, 600, ColorDepth.ColorDepth32);


                    pen.Color = Color.LimeGreen;
                    canvas.DrawRectangle(pen, 450, 450, 80, 60);

                    Console.ReadKey();

                    Stop();
                }
                catch (Exception e)
                {
                    mDebugger.Send("Exception occurred: " + e.Message);
                    mDebugger.Send(e.Message);
                    Stop();
                }
            }
            else
            {
                Console.WriteLine("Sorry! Command not recognized.");

            }
        }
    }
}
