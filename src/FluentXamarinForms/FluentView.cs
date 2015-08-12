﻿using System;
using Xamarin.Forms;

namespace FluentXamarinForms
{
    public abstract class FluentView<TView> : FluentVisualElement<TView>
        where TView: View, new()
    {
        public FluentView<TView> Horizontal (LayoutOptions options)
        {
            this.BuilderActions.Add (view => view.HorizontalOptions = options);

            return this;
        }

        public FluentView<TView> Vertical (LayoutOptions options)
        {
            this.BuilderActions.Add (view => view.VerticalOptions = options);

            return this;
        }
    }
}