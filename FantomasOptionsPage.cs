﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Shell;
using System.Runtime.InteropServices;
using Fantomas;

namespace FantomasVs
{
    [Guid(GuidString)]
    public class FantomasOptionsPage : DialogPage
    {
        public const string GuidString = "74927147-72e8-4b47-a70d-5568807d6878";

        public static FormatConfig.FormatConfig Defaults => FormatConfig.FormatConfig.Default;

        [Category("Indentation")]
        [DisplayName("Indent on Try...With")]
        public bool IndentOnTryWith { get; set; } = Defaults.IndentOnTryWith;

        [Category("Indentation")]
        [DisplayName("Indent Number of Spaces")]
        public int IndentSpaceNum { get; set; } = Defaults.IndentSpaceNum;

        [Category("Boundaries")]
        [DisplayName("Page Width")]
        public int PageWidth { get; set; } = Defaults.PageWidth;

        [Category("Boundaries")]
        [DisplayName("Maximum If-Then-Else Width")]
        public int MaxIfThenElseShortWidth { get; set; } = Defaults.MaxIfThenElseShortWidth;

        [Category("Convention")]
        [DisplayName("Semicolon at  End of Line")]
        public bool SemicolonAtEndOfLine { get; set; } = Defaults.SemicolonAtEndOfLine;


        [Category("Convention")]
        [DisplayName("Strict Mode")]
        public bool StrictMode { get; set; } = Defaults.StrictMode;

        [Category("Convention")]
        [DisplayName("Keep Newline After")]
        public bool KeepNewlineAfter { get; set; } = Defaults.KeepNewlineAfter;

        [Category("Spacing")]
        [DisplayName("Space Before Argument")]
        public bool SpaceBeforeArgument { get; set; } = Defaults.SpaceBeforeArgument;

        [Category("Spacing")]
        [DisplayName("Space Before Colon")]
        public bool SpaceBeforeColon { get; set; } = Defaults.SpaceBeforeColon;

        [Category("Spacing")]
        [DisplayName("Space After Comma")]
        public bool SpaceAfterComma { get; set; } = Defaults.SpaceAfterComma;

        [Category("Spacing")]
        [DisplayName("Space After Semicolon")]
        public bool SpaceAfterSemicolon { get; set; } = Defaults.SpaceAfterSemicolon;


        [Category("Spacing")]
        [DisplayName("Space Before Semicolon")]
        public bool SpaceBeforeSemicolon { get; set; } = Defaults.SpaceBeforeSemicolon;

        [Category("Spacing")]
        [DisplayName("Space Around Delimiter")]
        public bool SpaceAroundDelimiter { get; set; } = Defaults.SpaceAroundDelimiter;


        [Category("Ordering")]
        [DisplayName("Reorder Open Declaration")]
        public bool ReorderOpenDeclaration { get; set; } = Defaults.ReorderOpenDeclaration;

        [Category("Performance")]
        [DisplayName("Apply As Diff")]
        public bool ApplyDiff { get; set; } = true;

        [Category("Performance")]
        [DisplayName("Warmup Fantomas")]
        public bool WarmUpOnStartup { get; set; }

    }
}
