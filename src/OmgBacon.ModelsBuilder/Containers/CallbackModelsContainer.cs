﻿using System;
using OmgBacon.ModelsBuilder.Models;

namespace OmgBacon.ModelsBuilder.Containers {
    
    public class CallbackModelsContainer : IModelsContainer {

        private readonly Func<TypeModel, bool> _callback;

        public string Directory { get; set; }

        public CallbackModelsContainer(string directory, Func<TypeModel,bool> callback) {
            _callback = callback;
            Directory = directory;
        }

        public virtual bool Include(TypeModel type) {
            return _callback(type);
        }

    }

}