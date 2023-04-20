//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestBool4
    {
        [TestCompiler]
        public static void bool4_constructor()
        {
            bool4 a = new bool4(false, true, false, true);
            TestUtils.AreEqual(false, a.x);
            TestUtils.AreEqual(true, a.y);
            TestUtils.AreEqual(false, a.z);
            TestUtils.AreEqual(true, a.w);
        }

        [TestCompiler]
        public static void bool4_scalar_constructor()
        {
            bool4 a = new bool4(true);
            TestUtils.AreEqual(true, a.x);
            TestUtils.AreEqual(true, a.y);
            TestUtils.AreEqual(true, a.z);
            TestUtils.AreEqual(true, a.w);
        }

        [TestCompiler]
        public static void bool4_static_constructor()
        {
            bool4 a = bool4(false, true, false, true);
            TestUtils.AreEqual(false, a.x);
            TestUtils.AreEqual(true, a.y);
            TestUtils.AreEqual(false, a.z);
            TestUtils.AreEqual(true, a.w);
        }

        [TestCompiler]
        public static void bool4_static_scalar_constructor()
        {
            bool4 a = bool4(true);
            TestUtils.AreEqual(true, a.x);
            TestUtils.AreEqual(true, a.y);
            TestUtils.AreEqual(true, a.z);
            TestUtils.AreEqual(true, a.w);
        }

        [TestCompiler]
        public static void bool4_operator_equal_wide_wide()
        {
            bool4 a0 = bool4(true, false, true, false);
            bool4 b0 = bool4(true, false, false, false);
            bool4 r0 = bool4(true, true, false, true);
            TestUtils.AreEqual(r0, a0 == b0);

            bool4 a1 = bool4(false, true, false, false);
            bool4 b1 = bool4(true, false, false, true);
            bool4 r1 = bool4(false, false, true, false);
            TestUtils.AreEqual(r1, a1 == b1);

            bool4 a2 = bool4(true, false, true, false);
            bool4 b2 = bool4(false, false, false, false);
            bool4 r2 = bool4(false, true, false, true);
            TestUtils.AreEqual(r2, a2 == b2);

            bool4 a3 = bool4(true, true, false, true);
            bool4 b3 = bool4(true, false, false, false);
            bool4 r3 = bool4(true, false, true, false);
            TestUtils.AreEqual(r3, a3 == b3);
        }

        [TestCompiler]
        public static void bool4_operator_equal_wide_scalar()
        {
            bool4 a0 = bool4(false, true, false, false);
            bool b0 = (true);
            bool4 r0 = bool4(false, true, false, false);
            TestUtils.AreEqual(r0, a0 == b0);

            bool4 a1 = bool4(false, true, false, false);
            bool b1 = (false);
            bool4 r1 = bool4(true, false, true, true);
            TestUtils.AreEqual(r1, a1 == b1);

            bool4 a2 = bool4(false, true, false, true);
            bool b2 = (true);
            bool4 r2 = bool4(false, true, false, true);
            TestUtils.AreEqual(r2, a2 == b2);

            bool4 a3 = bool4(false, false, false, false);
            bool b3 = (true);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(r3, a3 == b3);
        }

        [TestCompiler]
        public static void bool4_operator_equal_scalar_wide()
        {
            bool a0 = (false);
            bool4 b0 = bool4(true, false, true, false);
            bool4 r0 = bool4(false, true, false, true);
            TestUtils.AreEqual(r0, a0 == b0);

            bool a1 = (false);
            bool4 b1 = bool4(true, false, false, true);
            bool4 r1 = bool4(false, true, true, false);
            TestUtils.AreEqual(r1, a1 == b1);

            bool a2 = (false);
            bool4 b2 = bool4(true, true, false, true);
            bool4 r2 = bool4(false, false, true, false);
            TestUtils.AreEqual(r2, a2 == b2);

            bool a3 = (false);
            bool4 b3 = bool4(true, true, true, false);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(r3, a3 == b3);
        }

        [TestCompiler]
        public static void bool4_operator_not_equal_wide_wide()
        {
            bool4 a0 = bool4(true, true, true, false);
            bool4 b0 = bool4(true, false, false, false);
            bool4 r0 = bool4(false, true, true, false);
            TestUtils.AreEqual(r0, a0 != b0);

            bool4 a1 = bool4(false, true, false, false);
            bool4 b1 = bool4(true, false, false, false);
            bool4 r1 = bool4(true, true, false, false);
            TestUtils.AreEqual(r1, a1 != b1);

            bool4 a2 = bool4(false, false, true, true);
            bool4 b2 = bool4(false, true, true, true);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(r2, a2 != b2);

            bool4 a3 = bool4(true, true, true, true);
            bool4 b3 = bool4(false, false, true, true);
            bool4 r3 = bool4(true, true, false, false);
            TestUtils.AreEqual(r3, a3 != b3);
        }

        [TestCompiler]
        public static void bool4_operator_not_equal_wide_scalar()
        {
            bool4 a0 = bool4(false, true, false, true);
            bool b0 = (false);
            bool4 r0 = bool4(false, true, false, true);
            TestUtils.AreEqual(r0, a0 != b0);

            bool4 a1 = bool4(true, false, false, false);
            bool b1 = (false);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(r1, a1 != b1);

            bool4 a2 = bool4(false, false, false, true);
            bool b2 = (false);
            bool4 r2 = bool4(false, false, false, true);
            TestUtils.AreEqual(r2, a2 != b2);

            bool4 a3 = bool4(false, false, false, true);
            bool b3 = (false);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(r3, a3 != b3);
        }

        [TestCompiler]
        public static void bool4_operator_not_equal_scalar_wide()
        {
            bool a0 = (true);
            bool4 b0 = bool4(false, false, true, false);
            bool4 r0 = bool4(true, true, false, true);
            TestUtils.AreEqual(r0, a0 != b0);

            bool a1 = (false);
            bool4 b1 = bool4(false, true, true, true);
            bool4 r1 = bool4(false, true, true, true);
            TestUtils.AreEqual(r1, a1 != b1);

            bool a2 = (false);
            bool4 b2 = bool4(false, false, false, false);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(r2, a2 != b2);

            bool a3 = (true);
            bool4 b3 = bool4(false, false, true, false);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(r3, a3 != b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_and_wide_wide()
        {
            bool4 a0 = bool4(false, false, true, true);
            bool4 b0 = bool4(false, false, true, false);
            bool4 r0 = bool4(false, false, true, false);
            TestUtils.AreEqual(r0, a0 & b0);

            bool4 a1 = bool4(false, false, true, true);
            bool4 b1 = bool4(true, true, false, false);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(r1, a1 & b1);

            bool4 a2 = bool4(true, false, true, true);
            bool4 b2 = bool4(true, true, false, false);
            bool4 r2 = bool4(true, false, false, false);
            TestUtils.AreEqual(r2, a2 & b2);

            bool4 a3 = bool4(true, true, false, false);
            bool4 b3 = bool4(false, false, true, false);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(r3, a3 & b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_and_wide_scalar()
        {
            bool4 a0 = bool4(true, false, false, true);
            bool b0 = (true);
            bool4 r0 = bool4(true, false, false, true);
            TestUtils.AreEqual(r0, a0 & b0);

            bool4 a1 = bool4(true, false, false, false);
            bool b1 = (false);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(r1, a1 & b1);

            bool4 a2 = bool4(false, true, true, false);
            bool b2 = (true);
            bool4 r2 = bool4(false, true, true, false);
            TestUtils.AreEqual(r2, a2 & b2);

            bool4 a3 = bool4(false, true, true, false);
            bool b3 = (true);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(r3, a3 & b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_and_scalar_wide()
        {
            bool a0 = (false);
            bool4 b0 = bool4(false, false, true, true);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(r0, a0 & b0);

            bool a1 = (true);
            bool4 b1 = bool4(false, true, false, false);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(r1, a1 & b1);

            bool a2 = (false);
            bool4 b2 = bool4(true, false, false, false);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(r2, a2 & b2);

            bool a3 = (true);
            bool4 b3 = bool4(true, true, true, false);
            bool4 r3 = bool4(true, true, true, false);
            TestUtils.AreEqual(r3, a3 & b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_or_wide_wide()
        {
            bool4 a0 = bool4(true, true, true, false);
            bool4 b0 = bool4(false, false, false, false);
            bool4 r0 = bool4(true, true, true, false);
            TestUtils.AreEqual(r0, a0 | b0);

            bool4 a1 = bool4(true, false, true, true);
            bool4 b1 = bool4(true, true, true, false);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(r1, a1 | b1);

            bool4 a2 = bool4(false, true, true, true);
            bool4 b2 = bool4(false, true, false, false);
            bool4 r2 = bool4(false, true, true, true);
            TestUtils.AreEqual(r2, a2 | b2);

            bool4 a3 = bool4(true, true, true, false);
            bool4 b3 = bool4(true, true, true, true);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(r3, a3 | b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_or_wide_scalar()
        {
            bool4 a0 = bool4(true, true, false, true);
            bool b0 = (true);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(r0, a0 | b0);

            bool4 a1 = bool4(true, true, false, true);
            bool b1 = (true);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(r1, a1 | b1);

            bool4 a2 = bool4(false, true, false, false);
            bool b2 = (false);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(r2, a2 | b2);

            bool4 a3 = bool4(true, true, true, true);
            bool b3 = (false);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(r3, a3 | b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_or_scalar_wide()
        {
            bool a0 = (true);
            bool4 b0 = bool4(true, true, false, false);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(r0, a0 | b0);

            bool a1 = (true);
            bool4 b1 = bool4(true, true, false, false);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(r1, a1 | b1);

            bool a2 = (true);
            bool4 b2 = bool4(true, false, true, true);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(r2, a2 | b2);

            bool a3 = (false);
            bool4 b3 = bool4(false, false, false, true);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(r3, a3 | b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_xor_wide_wide()
        {
            bool4 a0 = bool4(true, false, false, true);
            bool4 b0 = bool4(true, true, false, true);
            bool4 r0 = bool4(false, true, false, false);
            TestUtils.AreEqual(r0, a0 ^ b0);

            bool4 a1 = bool4(false, false, false, true);
            bool4 b1 = bool4(false, true, false, true);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(r1, a1 ^ b1);

            bool4 a2 = bool4(false, false, true, true);
            bool4 b2 = bool4(false, false, false, true);
            bool4 r2 = bool4(false, false, true, false);
            TestUtils.AreEqual(r2, a2 ^ b2);

            bool4 a3 = bool4(false, false, true, false);
            bool4 b3 = bool4(false, false, true, true);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(r3, a3 ^ b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_xor_wide_scalar()
        {
            bool4 a0 = bool4(false, false, true, true);
            bool b0 = (false);
            bool4 r0 = bool4(false, false, true, true);
            TestUtils.AreEqual(r0, a0 ^ b0);

            bool4 a1 = bool4(false, false, false, false);
            bool b1 = (false);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(r1, a1 ^ b1);

            bool4 a2 = bool4(false, true, false, true);
            bool b2 = (false);
            bool4 r2 = bool4(false, true, false, true);
            TestUtils.AreEqual(r2, a2 ^ b2);

            bool4 a3 = bool4(true, true, false, true);
            bool b3 = (true);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(r3, a3 ^ b3);
        }

        [TestCompiler]
        public static void bool4_operator_bitwise_xor_scalar_wide()
        {
            bool a0 = (true);
            bool4 b0 = bool4(true, false, true, true);
            bool4 r0 = bool4(false, true, false, false);
            TestUtils.AreEqual(r0, a0 ^ b0);

            bool a1 = (false);
            bool4 b1 = bool4(true, true, false, false);
            bool4 r1 = bool4(true, true, false, false);
            TestUtils.AreEqual(r1, a1 ^ b1);

            bool a2 = (true);
            bool4 b2 = bool4(true, false, false, true);
            bool4 r2 = bool4(false, true, true, false);
            TestUtils.AreEqual(r2, a2 ^ b2);

            bool a3 = (false);
            bool4 b3 = bool4(true, true, false, true);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(r3, a3 ^ b3);
        }

        [TestCompiler]
        public static void bool4_operator_logical_not()
        {
            bool4 a0 = bool4(true, true, false, false);
            bool4 r0 = bool4(false, false, true, true);
            TestUtils.AreEqual(r0, !a0);

            bool4 a1 = bool4(true, true, false, true);
            bool4 r1 = bool4(false, false, true, false);
            TestUtils.AreEqual(r1, !a1);

            bool4 a2 = bool4(false, false, false, true);
            bool4 r2 = bool4(true, true, true, false);
            TestUtils.AreEqual(r2, !a2);

            bool4 a3 = bool4(true, false, true, true);
            bool4 r3 = bool4(false, true, false, false);
            TestUtils.AreEqual(r3, !a3);
        }

        [TestCase]
        public static void bool4_EqualsObjectOverride()
        {
            TestUtils.IsFalse(new bool4().Equals((object)new int()));
            TestUtils.IsTrue(new bool4().Equals((object)new bool4()));
        }


    }
}