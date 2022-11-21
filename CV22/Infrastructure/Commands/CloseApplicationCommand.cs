﻿using CV22.Infrastructure.Commands.Base;
using System.Windows;

namespace CV22.Infrastructure.Commands
{
    class CloseApplicationCommand : Command
    {
        public override bool CanExecute(object? parameter) => true;      

        public override void Execute(object? parameter) => Application.Current.Shutdown();        
    }
}
