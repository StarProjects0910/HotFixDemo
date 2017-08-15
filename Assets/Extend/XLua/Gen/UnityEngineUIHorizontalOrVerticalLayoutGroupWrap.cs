﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class UnityEngineUIHorizontalOrVerticalLayoutGroupWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), L, translator, 0, 0, 5, 5);
			
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "spacing", _g_get_spacing);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childForceExpandWidth", _g_get_childForceExpandWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childForceExpandHeight", _g_get_childForceExpandHeight);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childControlWidth", _g_get_childControlWidth);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "childControlHeight", _g_get_childControlHeight);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "spacing", _s_set_spacing);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childForceExpandWidth", _s_set_childForceExpandWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childForceExpandHeight", _s_set_childForceExpandHeight);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childControlWidth", _s_set_childControlWidth);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "childControlHeight", _s_set_childControlHeight);
            
			Utils.EndObjectRegister(typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "UnityEngine.UI.HorizontalOrVerticalLayoutGroup does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_spacing(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.spacing);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childForceExpandWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.childForceExpandWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childForceExpandHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.childForceExpandHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childControlWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.childControlWidth);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_childControlHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.childControlHeight);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_spacing(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.spacing = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childForceExpandWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.childForceExpandWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childForceExpandHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.childForceExpandHeight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childControlWidth(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.childControlWidth = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_childControlHeight(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.UI.HorizontalOrVerticalLayoutGroup __cl_gen_to_be_invoked = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.childControlHeight = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}