﻿namespace Greenshot.Addon.Interfaces.Drawing
{
	public interface ITextContainer : IDrawableContainer
	{
		string Text { get; set; }

		void ChangeText(string newText, bool allowUndoable);

		void FitToText();
	}
}