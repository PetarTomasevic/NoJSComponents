﻿using System;
using Microsoft.AspNetCore.Components;

namespace NoJS.Modal.Services
{
    public interface INoJSModalService
    {
        /// <summary>
        /// Invoked when the modal component closes.
        /// </summary>
        event Action<NoJSModalResult> OnClose;

        /// <summary>
        /// Shows the modal using the specified title and component type.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="componentType">Type of component to display.</param>
        void Show(string title, Type contentType);

        /// <summary>
        /// Shows the modal using the specified title and component type.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="componentType">Type of component to display.</param>
        /// <param name="options">Options to configure the modal.</param>
        void Show(string title, Type componentType, NoJSModalOptions options);

        /// <summary>
        /// Shows the modal using the specified <paramref name="title"/> and <paramref name="componentType"/>, 
        /// passing the specified <paramref name="parameters"/>. 
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="componentType">Type of component to display.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        void Show(string title, Type contentType, NoJSModalParameters parameters);

        /// <summary>
        /// Shows the modal using the specified <paramref name="title"/> and <paramref name="componentType"/>, 
        /// passing the specified <paramref name="parameters"/> and setting a custom CSS style. 
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="componentType">Type of component to display.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        /// <param name="options">Options to configure the modal.</param>
        void Show(string title, Type componentType, NoJSModalParameters parameters, NoJSModalOptions options);

        void Show<T>(string title, NoJSModalParameters parameters = null, NoJSModalOptions options = null) where T : ComponentBase;

        /// <summary>
        /// Cancels the modal and invokes the <see cref="OnClose"/> event.
        /// </summary>
        void Cancel();

        /// <summary>
        /// Closes the modal and invokes the <see cref="OnClose"/> event with the specified <paramref name="modalResult"/>.
        /// </summary>
        /// <param name="modalResult"></param>
        void Close(NoJSModalResult modalResult);
    }
}
