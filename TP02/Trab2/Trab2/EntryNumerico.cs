//Kauê de Jesus Livio CB3005461
//Pedro Paulo dos Reis Faria CB3007278

using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Trab2
{
    class EntryNumerico : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int parsed;
            bool validar = int.TryParse(sender.Text, out parsed);
            if (!validar)
            {
                sender.TextColor = Color.Red;
            }
            else
            {
                sender.TextColor = Color.Blue;
            }
        }
    }
}
