﻿using System;
using System.Drawing;
using Microsoft.Xna.Framework.Graphics;
using Quaver.Assets;
using Quaver.Helpers;
using Wobble.Graphics;
using Wobble.Graphics.UI.Buttons;
using Color = Microsoft.Xna.Framework.Color;

namespace Quaver.Screens.Select.UI.Mods
{
    public class ModsDialogOption : TextButton
    {
        /// <summary>
        ///     Reference to the parent modifier
        /// </summary>
        private ModsDialogModifier Modifier { get; }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="modifier"></param>
        /// <param name="text"></param>
        /// <param name="clickAction"></param>
        public ModsDialogOption(ModsDialogModifier modifier, string text, EventHandler clickAction)
            : base(UserInterface.BlankBox, Fonts.Exo2Regular24, text, 0.55f, clickAction)
        {
            Modifier = modifier;
            Parent = Modifier;
            Tint = ColorHelper.HexToColor("#22af22");

            Size = new ScalableVector2(Text.MeasureString().X + 60, Modifier.Height * 0.55f);

            Deselect();
        }

        /// <summary>
        ///     Selects the button
        /// </summary>
        public void Select() => Alpha = 1;

        /// <summary>
        ///     Deselects the button.
        /// </summary>
        public void Deselect() => Alpha = 0;
    }
}