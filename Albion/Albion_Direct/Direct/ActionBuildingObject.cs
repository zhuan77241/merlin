﻿////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: a1x */
    public partial class ActionBuildingObject : BuildingObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();

        private a1x _internal;

        #region Properties

        public a1x ActionBuildingObject_Internal => _internal;

        #endregion

        #region Fields


        #endregion

        #region Methods


        #endregion

        #region Constructor

        public ActionBuildingObject(a1x instance) : base(instance)
        {
            _internal = instance;
        }

        static ActionBuildingObject()
        {

        }

        #endregion

        #region Conversion

        public static implicit operator a1x(ActionBuildingObject instance)
        {
            return instance._internal;
        }

        public static implicit operator ActionBuildingObject(a1x instance)
        {
            return new ActionBuildingObject(instance);
        }

        public static implicit operator bool(ActionBuildingObject instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
