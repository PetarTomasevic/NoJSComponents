using Microsoft.AspNetCore.Components;
using System;

namespace NoJS.Modal.Services
{
    public class NoJSModalService : INoJSModalService
    {
        /// <summary>
        /// Invoked when the modal component closes.
        /// </summary>
        public event Action<NoJSModalResult> OnClose;

        /// <summary>
        /// Internal event used to trigger the modal component to show.
        /// </summary>
        internal event Action<string, RenderFragment, NoJSModalParameters, NoJSModalOptions> OnShow;

        /// <summary>
        /// Shows the modal using the specified title and component type.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="componentType">Type of component to display.</param>
        public void Show(string title, Type componentType)
        {
            Show(title, componentType, new NoJSModalParameters(), new NoJSModalOptions());
        }

        /// <summary>
        /// Shows the modal using the specified title and component type.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="componentType">Type of component to display.</param>
        /// <param name="options">Options to configure the modal.</param>
        public void Show(string title, Type componentType, NoJSModalOptions options)
        {
            Show(title, componentType, new NoJSModalParameters(), options);
        }

        /// <summary>
        /// Shows the modal using the specified <paramref name="title"/> and <paramref name="componentType"/>,
        /// passing the specified <paramref name="parameters"/>.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="componentType">Type of component to display.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        public void Show(string title, Type componentType, NoJSModalParameters parameters)
        {
            Show(title, componentType, parameters, new NoJSModalOptions());
        }

        /// <summary>
        /// Shows the modal using the specified <paramref name="title"/> and <paramref name="componentType"/>,
        /// passing the specified <paramref name="parameters"/> and setting a custom CSS style.
        /// </summary>
        /// <param name="title">Modal title.</param>
        /// <param name="componentType">Type of component to display.</param>
        /// <param name="parameters">Key/Value collection of parameters to pass to component being displayed.</param>
        /// <param name="options">Options to configure the modal.</param>
        public void Show(string title, Type componentType, NoJSModalParameters parameters, NoJSModalOptions options)
        {
            if (!typeof(ComponentBase).IsAssignableFrom(componentType))
            {
                throw new ArgumentException($"{componentType.FullName} must be a Blazor Component");
            }

            var content = new RenderFragment(x => { x.OpenComponent(1, componentType); x.CloseComponent(); });

            OnShow?.Invoke(title, content, parameters, options);
        }

        /// <summary>
        /// Closes the modal and invokes the <see cref="OnClose"/> event.
        /// </summary>
        public void Cancel()
        {
            OnClose?.Invoke(NoJSModalResult.Cancel());
        }

        /// <summary>
        /// Closes the modal and invokes the <see cref="OnClose"/> event with the specified <paramref name="modalResult"/>.
        /// </summary>
        /// <param name="modalResult"></param>
        public void Close(NoJSModalResult modalResult)
        {
            OnClose?.Invoke(modalResult);
        }

        public void Show<T>(string title, NoJSModalParameters parameters = null, NoJSModalOptions options = null) where T : ComponentBase
        {
            Show(title,
                 typeof(T),
                 parameters ?? new NoJSModalParameters(),
                 options ?? new NoJSModalOptions());
        }
    }
}