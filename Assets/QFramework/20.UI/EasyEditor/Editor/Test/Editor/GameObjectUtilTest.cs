/****************************************************************************
 * Copyright (c) 2017 liuzhenhua@putao.com
 * 
 * http://qframework.io
 * https://github.com/liangxiegame/QFramework
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 ****************************************************************************/

namespace QFramework.Test.Core
{
	using UnityEngine;
	using UnityEditor;
	using NUnit.Framework;

	public class GameObjectUtilTest
	{

		[Test]
		public void GameObjectUtilTest_Extend_Bool()
		{
			//Arrange
			var gameObject = new GameObject();

			//Act
			//Try to rename the GameObject
			gameObject.Show();
			
			//Assert
			//The object has a new name
			Assert.AreEqual(true, gameObject.activeSelf);
			
			gameObject.Hide();
			Assert.AreEqual(false,gameObject.activeSelf);
		}
	}
}
