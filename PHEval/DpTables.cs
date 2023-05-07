/*
 *  Copyright 2016 Henry Lee
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

namespace PHEval {
    class DpTables {
        public static uint[,] choose = {
            {
                1,  0,  0,  0,  0,
                0,  0,  0,  0,  0,
            },
            {
                1,  1,  0,  0,  0,
                0,  0,  0,  0,  0,
            },
            {
                1,  2,  1,  0,  0,
                0,  0,  0,  0,  0,
            },
            {
                1,  3,  3,  1,  0,
                0,  0,  0,  0,  0,
            },
            {
                1,  4,  6,  4,  1,
                0,  0,  0,  0,  0,
            },
            {
                1,  5,  10,  10,  5,
                1,  0,  0,  0,  0,
            },
            {
                1,  6,  15,  20,  15,
                6,  1,  0,  0,  0,
            },
            {
                1,  7,  21,  35,  35,
                21,  7,  1,  0,  0,
            },
            {
                1,  8,  28,  56,  70,
                56,  28,  8,  1,  0,
            },
            {
                1,  9,  36,  84,  126,
                126,  84,  36,  9,  1,
            },
            {
                1,  10,  45,  120,  210,
                252,  210,  120,  45,  10,
            },
            {
                1,  11,  55,  165,  330,
                462,  462,  330,  165,  55,
            },
            {
                1,  12,  66,  220,  495,
                792,  924,  792,  495,  220,
            },
            {
                1,  13,  78,  286,  715,
                1287,  1716,  1716,  1287,  715,
            },
            {
                1,  14,  91,  364,  1001,
                2002,  3003,  3432,  3003,  2002,
            },
            {
                1,  15,  105,  455,  1365,
                3003,  5005,  6435,  6435,  5005,
            },
            {
                1,  16,  120,  560,  1820,
                4368,  8008,  11440,  12870,  11440,
            },
            {
                1,  17,  136,  680,  2380,
                6188,  12376,  19448,  24310,  24310,
            },
            {
                1,  18,  153,  816,  3060,
                8568,  18564,  31824,  43758,  48620,
            },
            {
                1,  19,  171,  969,  3876,
                11628,  27132,  50388,  75582,  92378,
            },
            {
                1,  20,  190,  1140,  4845,
                15504,  38760,  77520,  125970,  167960,
            },
            {
                1,  21,  210,  1330,  5985,
                20349,  54264,  116280,  203490,  293930,
            },
            {
                1,  22,  231,  1540,  7315,
                26334,  74613,  170544,  319770,  497420,
            },
            {
                1,  23,  253,  1771,  8855,
                33649,  100947,  245157,  490314,  817190,
            },
            {
                1,  24,  276,  2024,  10626,
                42504,  134596,  346104,  735471,  1307504,
            },
            {
                1,  25,  300,  2300,  12650,
                53130,  177100,  480700,  1081575,  2042975,
            },
            {
                1,  26,  325,  2600,  14950,
                65780,  230230,  657800,  1562275,  3124550,
            },
            {
                1,  27,  351,  2925,  17550,
                80730,  296010,  888030,  2220075,  4686825,
            },
            {
                1,  28,  378,  3276,  20475,
                98280,  376740,  1184040,  3108105,  6906900,
            },
            {
                1,  29,  406,  3654,  23751,
                118755,  475020,  1560780,  4292145,  10015005,
            },
            {
                1,  30,  435,  4060,  27405,
                142506,  593775,  2035800,  5852925,  14307150,
            },
            {
                1,  31,  465,  4495,  31465,
                169911,  736281,  2629575,  7888725,  20160075,
            },
            {
                1,  32,  496,  4960,  35960,
                201376,  906192,  3365856,  10518300,  28048800,
            },
            {
                1,  33,  528,  5456,  40920,
                237336,  1107568,  4272048,  13884156,  38567100,
            },
            {
                1,  34,  561,  5984,  46376,
                278256,  1344904,  5379616,  18156204,  52451256,
            },
            {
                1,  35,  595,  6545,  52360,
                324632,  1623160,  6724520,  23535820,  70607460,
            },
            {
                1,  36,  630,  7140,  58905,
                376992,  1947792,  8347680,  30260340,  94143280,
            },
            {
                1,  37,  666,  7770,  66045,
                435897,  2324784,  10295472,  38608020,  124403620,
            },
            {
                1,  38,  703,  8436,  73815,
                501942,  2760681,  12620256,  48903492,  163011640,
            },
            {
                1,  39,  741,  9139,  82251,
                575757,  3262623,  15380937,  61523748,  211915132,
            },
            {
                1,  40,  780,  9880,  91390,
                658008,  3838380,  18643560,  76904685,  273438880,
            },
            {
                1,  41,  820,  10660,  101270,
                749398,  4496388,  22481940,  95548245,  350343565,
            },
            {
                1,  42,  861,  11480,  111930,
                850668,  5245786,  26978328,  118030185,  445891810,
            },
            {
                1,  43,  903,  12341,  123410,
                962598,  6096454,  32224114,  145008513,  563921995,
            },
            {
                1,  44,  946,  13244,  135751,
                1086008,  7059052,  38320568,  177232627,  708930508,
            },
            {
                1,  45,  990,  14190,  148995,
                1221759,  8145060,  45379620,  215553195,  886163135,
            },
            {
                1,  46,  1035,  15180,  163185,
                1370754,  9366819,  53524680,  260932815,  1101716330,
            },
            {
                1,  47,  1081,  16215,  178365,
                1533939,  10737573,  62891499,  314457495,  1362649145,
            },
            {
                1,  48,  1128,  17296,  194580,
                1712304,  12271512,  73629072,  377348994,  1677106640,
            },
            {
                1,  49,  1176,  18424,  211876,
                1906884,  13983816,  85900584,  450978066,  2054455634,
            },
            {
                1,  50,  1225,  19600,  230300,
                2118760,  15890700,  99884400,  536878650,  2505433700,
            },
            {
                1,  51,  1275,  20825,  249900,
                2349060,  18009460,  115775100,  636763050,  3042312350,
            },
            {
                1,  52,  1326,  22100,  270725,
                2598960,  20358520,  133784560,  752538150,  3679075400,
            },
        };

        public static int[, ,]dp = {
            {
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
            },
            {
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 1,  1,  1,  1,  1,  0,  0,  0,  0,  0 },
                { 1,  2,  3,  4,  5,  4,  3,  2,  1,  0 },
                { 1,  3,  6,  10,  15,  18,  19,  18,  15,  10 },
                { 1,  4,  10,  20,  35,  52,  68,  80,  85,  80 },
                { 1,  5,  15,  35,  70,  121,  185,  255,  320,  365 },
                { 1,  6,  21,  56,  126,  246,  426,  666,  951,  1246 },
                { 1,  7,  28,  84,  210,  455,  875,  1520,  2415,  3535 },
                { 1,  8,  36,  120,  330,  784,  1652,  3144,  5475,  8800 },
                { 1,  9,  45,  165,  495,  1278,  2922,  6030,  11385,  19855 },
                { 1,  10,  55,  220,  715,  1992,  4905,  10890,  22110,  41470 },
                { 1,  11,  66,  286,  1001,  2992,  7887,  18722,  40612,  81367 },
                { 1,  12,  78,  364,  1365,  4356,  12232,  30888,  71214,  151580 },
                { 1,  13,  91,  455,  1820,  6175,  18395,  49205,  120055,  270270 },
            },
            {
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 1,  2,  2,  2,  2,  1,  0,  0,  0,  0 },
                { 1,  3,  5,  7,  9,  9,  7,  5,  3,  1 },
                { 1,  4,  9,  16,  25,  33,  37,  37,  33,  25 },
                { 1,  5,  14,  30,  55,  87,  120,  148,  165,  165 },
                { 1,  6,  20,  50,  105,  191,  306,  440,  575,  685 },
                { 1,  7,  27,  77,  182,  372,  672,  1092,  1617,  2197 },
                { 1,  8,  35,  112,  294,  665,  1330,  2395,  3935,  5950 },
                { 1,  9,  44,  156,  450,  1114,  2436,  4796,  8619,  14275 },
                { 1,  10,  54,  210,  660,  1773,  4200,  8952,  17415,  31240 },
                { 1,  11,  65,  275,  935,  2707,  6897,  15795,  33000,  63580 },
                { 1,  12,  77,  352,  1287,  3993,  10879,  26609,  59334,  121979 },
                { 1,  13,  90,  442,  1729,  5721,  16588,  43120,  102102,  222794 },
                { 1,  14,  104,  546,  2275,  7995,  24570,  67600,  169260,  390325 },
            },
            {
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 1,  2,  3,  3,  3,  2,  1,  0,  0,  0 },
                { 1,  3,  6,  9,  12,  13,  12,  9,  6,  3 },
                { 1,  4,  10,  19,  31,  43,  52,  55,  52,  43 },
                { 1,  5,  15,  34,  65,  107,  155,  200,  233,  245 },
                { 1,  6,  21,  55,  120,  226,  376,  561,  760,  940 },
                { 1,  7,  28,  83,  203,  428,  798,  1338,  2043,  2863 },
                { 1,  8,  36,  119,  322,  749,  1540,  2850,  4810,  7470 },
                { 1,  9,  45,  164,  486,  1234,  2766,  5580,  10271,  17419 },
                { 1,  10,  55,  219,  705,  1938,  4695,  10230,  20337,  37270 },
                { 1,  11,  66,  285,  990,  2927,  7612,  17787,  37905,  74470 },
                { 1,  12,  78,  363,  1353,  4279,  11880,  29601,  67221,  140701 },
                { 1,  13,  91,  454,  1807,  6085,  17953,  47476,  114334,  253682 },
                { 1,  14,  105,  559,  2366,  8450,  26390,  73775,  187655,  439530 },
            },
            {
                { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0 },
                { 1,  2,  3,  4,  4,  3,  2,  1,  0,  0 },
                { 1,  3,  6,  10,  14,  16,  16,  14,  10,  6 },
                { 1,  4,  10,  20,  34,  49,  62,  70,  70,  62 },
                { 1,  5,  15,  35,  69,  117,  175,  235,  285,  313 },
                { 1,  6,  21,  56,  125,  241,  411,  631,  881,  1125 },
                { 1,  7,  28,  84,  209,  449,  854,  1464,  2289,  3289 },
                { 1,  8,  36,  120,  329,  777,  1624,  3060,  5265,  8345 },
                { 1,  9,  45,  165,  494,  1270,  2886,  5910,  11055,  19071 },
                { 1,  10,  55,  220,  714,  1983,  4860,  10725,  21615,  40192 },
                { 1,  11,  66,  286,  1000,  2982,  7832,  18502,  39897,  79375 },
                { 1,  12,  78,  364,  1364,  4345,  12166,  30602,  70213,  148588 },
                { 1,  13,  91,  455,  1819,  6163,  18317,  48841,  118690,  265914 },
                { 1,  14,  105,  560,  2379,  8541,  26845,  75595,  193830,  457925 },
            },
        };

        public static byte[] suits = {
            0,  0,  0,  0,  0,  1,  1,  1,
            1,  1,  0,  0,  0,  1,  1,  1,
            1,  0,  0,  0,  0,  1,  1,  1,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            2,  2,  2,  2,  2,  0,  0,  0,
            2,  2,  2,  2,  0,  0,  0,  0,
            2,  2,  2,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  1,  1,  1,
            1,  0,  0,  0,  0,  1,  1,  1,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  2,  2,  0,  0,  0,  0,
            2,  2,  2,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  1,  1,  1,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  2,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  3,  3,  3,  0,  0,  0,
            3,  3,  3,  3,  0,  0,  0,  0,
            3,  3,  3,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  3,  3,  0,  0,  0,  0,
            3,  3,  3,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  3,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  1,  1,  1,
            3,  0,  0,  0,  0,  1,  1,  1,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  2,  2,  0,  0,  0,  0,
            2,  2,  2,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  1,  1,  1,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  2,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  3,  3,  0,  0,  0,  0,
            3,  3,  3,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  3,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  1,  1,  1,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  2,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  3,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  1,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  2,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  3,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  1,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            2,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            3,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  4,  4,  4,  0,  0,  0,
            4,  4,  4,  4,  0,  0,  0,  0,
            4,  4,  4,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  4,  4,  0,  0,  0,  0,
            4,  4,  4,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  4,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  4,  4,  0,  0,  0,  0,
            4,  4,  4,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  4,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  4,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  4,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            0,  0,  0,  0,  0,  0,  0,  0,
            4,
        };
    }
}