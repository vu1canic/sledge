#pragma once
#include <unordered_map>
#include <string>

inline std::unordered_map<std::string, unsigned __int64> g_Offsets = {
	 {"SetBool", 0x000000000013AAB0 },
	 {"lua_setfield", 0x0000000000243A00 },
	 {"memmove", 0x0000000000290480 },
	 {"UpdateToolBodies", 0x00000000000CD0F0 },
	 {"realloc", 0x00000000002F75F0 },
	 {"lua_gettop", 0x0000000000242920 },
	 {"SetCursorCaptured", 0x000000000016D930 },
	 {"free", 0x00000000002EDDD4 },
	 {"DebugPrint", 0x000000000010F070 },
	 {"SetInt", 0x000000000013ABC0 },
	 {"ScriptCore::RegisterLuaFunctions", 0x000000000014F000 },
	 {"calloc", 0x00000000002F12B4 },
	 {"Screen::Screen", 0x000000000013C850 },
	 {"malloc", 0x00000000002EDE14 },
	 {"GetFloat", 0x0000000000139C20 },
	 {"SetString", 0x000000000013AC30 },
	 {"SetFloat", 0x000000000013AB50 },
	 {"GetBool", 0x0000000000139B70 },
	 {"InitializeBody", 0x00000000000041B0 },
	 {"GetInt", 0x0000000000139C70 },
	 {"GetString", 0x0000000000139CC0 },
	 {"lua_pushcclosure", 0x0000000000243140 },
	 {"SetTag", 0x0000000000110730 },
	 {"HasTag", 0x00000000001103A0 },
	 {"RemoveTag", 0x00000000001104C0 },
	 {"GetTag", 0x0000000000110210 },
	 {"Game::Game", 0x0000000000038CC0 },
	 {"QueryClosestPoint", 0x00000000000D80A0 },
	 {"Body::Body", 0x00000000000BAD70 },
	 {"lua_createtable", 0x0000000000242100 },
	 {"Shape::Shape", 0x000000000015E120 },
	 {"lua_pushboolean", 0x0000000000243120 },
	 {"Light::Light", 0x0000000000123F90 },
	 {"Joint::Joint", 0x00000000000BAE50 },
	 {"Script::Script", 0x000000000013E5E0 },
	 {"LoadVox", 0x00000000001054B0 },
	 {"GenVoxTexture", 0x00000000000FAB90 },
	 {"GenVoxBuffers", 0x00000000000FA8E0 },
	 {"UpdateBodyActive", 0x00000000000B8880 },
	 {"InitializeBodyDynamic", 0x00000000000BABC0 },
	 {"AttachJoint", 0x00000000001214B0 },
	 {"DetachJoint", 0x000000000011DC50 },
	 {"Update", 0x000000000003B6C0 },
	 {"SwitchGameState", 0x000000000003E090 },
	 {"ChangeLevel", 0x000000000003E8C0 },
	 {"UpdatePlayer", 0x00000000000BFD70 },
	 {"UpdateShadowVolumes", 0x00000000000EC880 },
	 {"DrawScene", 0x00000000000483E0 },
	 {"IsWindowForegroundWindow", 0x000000000016CF00 },
	 {"DrawLine", 0x0000000000047C90 },
	 {"WriteToConsole", 0x000000000016F4B0 },
	 {"lua_tonumber", 0x0000000000243F20 },
	 {"lua_topointer", 0x0000000000243F80 },
	 {"lua_tointeger", 0x0000000000243E20 },
	 {"lua_pushlightuserdata", 0x0000000000243270 },
	 {"lua_toboolean", 0x0000000000243DC0 },
	 {"lua_tolstring", 0x0000000000243E80 },
	 {"lua_pushlstring", 0x0000000000243290 },
	 {"lua_pushnil", 0x0000000000243300 },
	 {"lua_pushnumber", 0x0000000000243320 },
	 {"lua_pushinteger", 0x0000000000243250 },
	 {"QueryRaycast", 0x00000000000E43B0 },
	 {"MakeHole", 0x000000000010C1F0 },
	 {"Log", 0x000000000016F4B0 },
};