﻿using System;
using System.Management.Automation;
using Illallangi.CloudStoragePS.Config;

namespace Illallangi.CloudStoragePS
{
    [Cmdlet(VerbsLifecycle.Wait, "AnyKey")]
    public sealed class WaitAnyKey : PSCmdlet
    {
        private string currentPrompt = @"Press any key to continue...";

        [Parameter]
        public string Prompt
        {
            get
            {
                return this.currentPrompt;
            }

            set
            {
                this.currentPrompt = value;
            }
        }

        [Parameter(ValueFromPipeline = true)]
        public object Input { get; set; }

        protected override void ProcessRecord()
        {
            Console.Write(this.Prompt);
            Console.ReadKey();
            Console.WriteLine();
            this.WriteObject(this.Input);
        }
    }
}
