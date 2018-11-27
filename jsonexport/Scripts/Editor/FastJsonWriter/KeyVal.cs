﻿using UnityEngine;
using UnityEditor;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace SceneExport{
	public partial class FastJsonWriter{
		public void writeKeyVal(string key, int val){
			writeKey(key);
			writeRawValue(val);
		}

		public void writeKeyVal(string key, byte val){
			writeKey(key);
			writeRawValue(val);
		}

		public void writeKeyVal(string key, float val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal(string key, string val){
			writeKey(key);
			writeRawValue(val);
		}

		public void writeKeyVal(string key, bool val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal(string key, Color val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal(string key, Color32 val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal(string key, Vector2 val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal(string key, Vector3 val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal(string key, Vector4 val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal(string key, Matrix4x4 val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal(string key, Quaternion val){
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal<T>(string key, T val) where T: IFastJsonValue{
			writeKey(key);
			writeRawValue(val);
		}
		
		public void writeKeyVal<T>(string key, T[] val) where T: IFastJsonValue{
			writeKey(key);
			writeRawValue(val, 1);
		}		
		
		public void writeKeyVal<T>(string key, T[] val, int stride) where T: IFastJsonValue{
			writeKey(key);
			writeRawValue(val, stride);
		}		
	}
}