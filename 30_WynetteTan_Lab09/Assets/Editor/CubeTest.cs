using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class CubeTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void DisableOnDeath_EmptyHP_ObjectSetInactive()
        {
            GameObject testObject = MakeFakeCube(0);

            Assert.IsFalse(testObject.activeSelf);
        }

        [Test]
        public void DisableOnDeath_HasHP_ObjectRemainsActive()
        {
            GameObject testObject = MakeFakeCube(20);
            Assert.IsTrue(testObject.activeSelf);
        }

        private static GameObject MakeFakeCube(int hp)
        {
            GameObject testObject = new GameObject();
            Cube cubeScript = testObject.AddComponent<Cube>();

            cubeScript.health = hp;
            cubeScript.DisableOnDeath();
            return testObject;
        }
    }
}
