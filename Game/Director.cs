using System;
namespace jumper.Game
{
    public class Director
    {
        public void StartGame()
        {
           TerminalService terminalService = new TerminalService();
           terminalService.RenderOutPut();
        }
    }
}