using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Teste;

bool whatsappIsOpen = false;
foreach (var p in Process.GetProcessesByName("WhatsApp"))
{
    whatsappIsOpen = true;
}
string[] mensagens = { "Tudo bem", "Estou testando uma automatizaçao de whatsapp" };
var mensagem = new WhatsappMensagem() { Destinatario = "", Mensagens = mensagens };
KeyBoardOperations.SendKeyPress(KeyCode.LWIN);
Thread.Sleep(500);
string str = "WhatsApp";
foreach (char c in str.ToCharArray())
{
    RetornaCodigo(c);
    Thread.Sleep(500);
}
KeyBoardOperations.SendKeyPress(KeyCode.ENTER);
if (!whatsappIsOpen)
    Thread.Sleep(20000);
else
    Thread.Sleep(2000);
KeyBoardOperations.SendKeyDown(KeyCode.LCONTROL);
Thread.Sleep(500);
KeyBoardOperations.SendKeyPress(KeyCode.KEY_F);
Thread.Sleep(500);
KeyBoardOperations.SendKeyUp(KeyCode.LCONTROL);
Thread.Sleep(1000);
foreach (char c in mensagem.Destinatario.ToCharArray())
{
    RetornaCodigo(c);
    Thread.Sleep(500);
}
KeyBoardOperations.SendKeyPress(KeyCode.ENTER);
Thread.Sleep(1000);
Console.WriteLine("Pesquisando Whatsapp");
foreach (string msg in mensagem.Mensagens) {
    foreach (char c in msg.ToCharArray())
    {
        RetornaCodigo(c);
        Thread.Sleep(500);
    }
    KeyBoardOperations.SendKeyPress(KeyCode.ENTER);
    Thread.Sleep(1000);
}


static void RetornaCodigo(char caracter)
{
    switch (caracter)
    {
        case '0':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_0);
            break;
        case '1':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_1);
            break;
        case '2':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_2);
            break;
        case '3':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_3);
            break;
        case '4':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_4);
            break;
        case '5':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_5);
            break;
        case '6':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_6);
            break;
        case '7':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_7);
            break;
        case '8':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_8);
            break;
        case '9':
            KeyBoardOperations.SendKeyPress(KeyCode.KEY_9);
            break;
        case 'A' or 'a':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_A);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_A);
                break;
            }
        case 'B' or 'b':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_B);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_B);
                break;
            }
        case 'C' or 'c':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_C);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_C);
                break;
            }
        case 'D' or 'd':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_D);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_D);
                break;
            }
        case 'E' or 'e':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_E);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_E);
                break;
            }
        case 'F' or 'f':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_F);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_F);
                break;
            }
        case 'G' or 'g':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_G);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_G);
                break;
            }
        case 'H' or 'h':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_H);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_H);
                break;
            }
        case 'I' or 'i':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_I);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_I);
                break;
            }
        case 'J' or 'j':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_A);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_A);
                break;
            }
        case 'K' or 'k':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_K);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_K);
                break;
            }
        case 'L' or 'l':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_L);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_L);
                break;
            }
        case 'M' or 'm':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_M);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_M);
                break;
            }
        case 'N' or 'n':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_N);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_N);
                break;
            }
        case 'O' or 'o':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_O);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_O);
                break;
            }
        case 'P' or 'p':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_P);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_P);
                break;
            }
        case 'Q' or 'q':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_Q);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_Q);
                break;
            }
        case 'R' or 'r':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_R);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_R);
                break;
            }
        case 'S' or 's':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_S);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_S);
                break;
            }
        case 'T' or 't':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_T);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_T);
                break;
            }
        case 'U' or 'u':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_U);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_U);
                break;
            }
        case 'V' or 'v':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_V);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_V);
                break;
            }
        case 'W' or 'w':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_W);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_W);
                break;
            }
        case 'X' or 'x':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_X);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_X);
                break;
            }
        case 'Y' or 'y':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_Y);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_Y);
                break;
            }
        case 'Z' or 'z':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_Z);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.KEY_Z);
                break;
            }
        case ' ':
            KeyBoardOperations.SendKeyPress(KeyCode.SPACE_BAR);
            break;
        case 'Ç' or 'ç':
            if (char.IsUpper(caracter))
            {
                KeyBoardOperations.SendKeyDown(KeyCode.LSHIFT);
                KeyBoardOperations.SendKeyPress(KeyCode.OEM_CCEDILLA);
                KeyBoardOperations.SendKeyUp(KeyCode.LSHIFT);
                break;
            }
            else
            {
                KeyBoardOperations.SendKeyPress(KeyCode.OEM_CCEDILLA);
                break;
            }
    }


}

class WhatsappMensagem
{
    public string Destinatario { get; set; }
    public string[] Mensagens { get; set; }
}