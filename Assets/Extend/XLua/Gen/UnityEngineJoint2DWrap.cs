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
    public class UnityEngineJoint2DWrap
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			Utils.BeginObjectRegister(typeof(UnityEngine.Joint2D), L, translator, 0, 2, 6, 4);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetReactionForce", _m_GetReactionForce);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "GetReactionTorque", _m_GetReactionTorque);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "connectedBody", _g_get_connectedBody);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "enableCollision", _g_get_enableCollision);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breakForce", _g_get_breakForce);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "breakTorque", _g_get_breakTorque);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reactionForce", _g_get_reactionForce);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "reactionTorque", _g_get_reactionTorque);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "connectedBody", _s_set_connectedBody);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "enableCollision", _s_set_enableCollision);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breakForce", _s_set_breakForce);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "breakTorque", _s_set_breakTorque);
            
			Utils.EndObjectRegister(typeof(UnityEngine.Joint2D), L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(typeof(UnityEngine.Joint2D), L, __CreateInstance, 1, 0, 0);
			
			
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "UnderlyingSystemType", typeof(UnityEngine.Joint2D));
			
			
			Utils.EndClassRegister(typeof(UnityEngine.Joint2D), L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			try {
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					UnityEngine.Joint2D __cl_gen_ret = new UnityEngine.Joint2D();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to UnityEngine.Joint2D constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetReactionForce(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float timeStep = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        UnityEngine.Vector2 __cl_gen_ret = __cl_gen_to_be_invoked.GetReactionForce( timeStep );
                        translator.PushUnityEngineVector2(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetReactionTorque(RealStatePtr L)
        {
            
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
            
            
            try {
                
                {
                    float timeStep = (float)LuaAPI.lua_tonumber(L, 2);
                    
                        float __cl_gen_ret = __cl_gen_to_be_invoked.GetReactionTorque( timeStep );
                        LuaAPI.lua_pushnumber(L, __cl_gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_connectedBody(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.connectedBody);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_enableCollision(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushboolean(L, __cl_gen_to_be_invoked.enableCollision);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breakForce(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.breakForce);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_breakTorque(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.breakTorque);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reactionForce(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                translator.PushUnityEngineVector2(L, __cl_gen_to_be_invoked.reactionForce);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_reactionTorque(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                LuaAPI.lua_pushnumber(L, __cl_gen_to_be_invoked.reactionTorque);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_connectedBody(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.connectedBody = (UnityEngine.Rigidbody2D)translator.GetObject(L, 2, typeof(UnityEngine.Rigidbody2D));
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_enableCollision(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.enableCollision = LuaAPI.lua_toboolean(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breakForce(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.breakForce = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_breakTorque(RealStatePtr L)
        {
            ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            try {
			
                UnityEngine.Joint2D __cl_gen_to_be_invoked = (UnityEngine.Joint2D)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.breakTorque = (float)LuaAPI.lua_tonumber(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
