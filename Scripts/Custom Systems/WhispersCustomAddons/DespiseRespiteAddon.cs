
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class DespiseRespiteAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {1822, -5, -12, 60}, {90, -16, -14, 64}, {1305, -10, -12, 65}// 1	2	4	
			, {1305, -10, -11, 65}, {87, -16, -9, 64}, {1305, -15, -13, 84}// 5	6	7	
			, {1305, -9, -13, 65}, {1305, -11, -11, 65}, {1822, -11, -8, 60}// 8	9	10	
			, {1305, -15, -9, 84}, {2880, -14, -8, 64}, {88, -15, -14, 64}// 11	12	13	
			, {1305, -12, -9, 84}, {1305, -6, -7, 84}, {1822, -15, -8, 60}// 14	15	16	
			, {1822, -15, -10, 60}, {1305, -8, -10, 84}, {1822, -9, -13, 89}// 17	18	19	
			, {1305, -8, -13, 65}, {4635, -12, -12, 84}, {1822, -10, -9, 60}// 20	21	22	
			, {1305, -15, -13, 65}, {1305, -10, -7, 84}, {1822, -5, -10, 60}// 23	24	25	
			, {1822, -6, -12, 84}, {89, -5, -12, 63}, {1305, -11, -12, 65}// 26	27	28	
			, {1305, -15, -7, 84}, {1822, -9, -11, 89}, {88, -7, -14, 64}// 29	30	31	
			, {1822, -12, -7, 60}, {6414, -5, -13, 64}, {88, -14, -14, 64}// 32	33	34	
			, {1305, -9, -9, 65}, {1822, -13, -10, 60}, {88, -10, -14, 64}// 35	36	37	
			, {105, -15, -14, 84}, {1822, -10, -10, 60}, {4632, -13, -13, 84}// 38	39	40	
			, {1822, -8, -12, 89}, {1305, -11, -12, 84}, {1305, -11, -13, 65}// 41	42	43	
			, {1305, -7, -9, 84}, {1822, -11, -10, 60}, {1305, -13, -12, 84}// 44	45	46	
			, {1822, -14, -8, 60}, {1822, -10, -13, 60}, {88, -13, -14, 64}// 47	48	49	
			, {1822, -7, -11, 89}, {1305, -12, -11, 65}, {1822, -11, -13, 60}// 50	51	52	
			, {1305, -10, -13, 84}, {1305, -15, -10, 65}, {1305, -14, -12, 65}// 53	54	55	
			, {1305, -15, -9, 65}, {1822, -6, -9, 60}, {1822, -9, -9, 89}// 56	57	58	
			, {4633, -9, -10, 94}, {1305, -5, -13, 84}, {105, -8, -14, 84}// 60	61	62	
			, {1305, -11, -10, 65}, {1305, -14, -8, 84}, {1305, -10, -11, 84}// 63	64	65	
			, {1822, -12, -11, 60}, {4633, -15, -11, 84}, {1305, -8, -12, 84}// 66	67	68	
			, {1822, -9, -11, 84}, {1305, -9, -11, 65}, {2880, -14, -12, 84}// 69	70	72	
			, {1822, -13, -12, 60}, {1305, -7, -8, 84}, {1822, -12, -10, 60}// 73	74	75	
			, {1822, -5, -7, 60}, {87, -5, -8, 63}, {1305, -9, -8, 65}// 76	77	78	
			, {1305, -10, -12, 84}, {1822, -6, -10, 60}, {106, -16, -11, 84}// 79	80	81	
			, {1305, -13, -9, 65}, {3084, -12, -11, 65}, {4635, -6, -10, 94}// 82	83	84	
			, {1305, -12, -12, 65}, {1305, -9, -12, 65}, {88, -14, -12, 64}// 85	86	87	
			, {105, -9, -14, 84}, {1782, -5, -10, 64}, {1305, -14, -12, 84}// 88	89	90	
			, {1822, -13, -7, 60}, {1822, -8, -11, 84}, {1822, -5, -9, 60}// 91	92	93	
			, {2880, -13, -11, 84}, {1305, -15, -11, 65}, {4632, -8, -12, 94}// 94	95	96	
			, {1305, -13, -10, 65}, {1305, -15, -11, 84}, {1305, -14, -10, 84}// 97	98	99	
			, {1822, -6, -9, 89}, {88, -12, -12, 64}, {1822, -12, -9, 60}// 100	101	102	
			, {1305, -14, -13, 65}, {1822, -8, -13, 89}, {1822, -14, -13, 60}// 103	104	105	
			, {1305, -13, -7, 65}, {1305, -9, -10, 65}, {1305, -11, -9, 84}// 106	107	108	
			, {1305, -13, -8, 65}, {1822, -11, -12, 60}, {2880, -13, -12, 84}// 109	110	111	
			, {1822, -11, -7, 60}, {2880, -7, -11, 94}, {1822, -8, -11, 89}// 112	113	114	
			, {2880, -14, -11, 84}, {1822, -12, -13, 60}, {1822, -13, -13, 60}// 115	116	117	
			, {1305, -5, -10, 84}, {1822, -13, -8, 60}, {1305, -13, -13, 84}// 118	119	120	
			, {1822, -8, -9, 89}, {1305, -7, -11, 84}, {1822, -6, -13, 60}// 121	122	123	
			, {4633, -15, -12, 84}, {1822, -15, -13, 60}, {1305, -14, -9, 65}// 124	125	126	
			, {1305, -10, -8, 65}, {1305, -11, -9, 65}, {1822, -13, -9, 60}// 127	128	129	
			, {88, -8, -14, 64}, {88, -7, -12, 63}, {88, -9, -14, 64}// 130	131	132	
			, {88, -8, -12, 63}, {1305, -11, -8, 65}, {88, -11, -14, 64}// 133	134	135	
			, {1305, -10, -8, 84}, {1305, -13, -12, 65}, {1305, -10, -13, 65}// 136	137	138	
			, {1305, -12, -9, 65}, {1305, -14, -13, 84}, {1822, -15, -7, 60}// 139	140	141	
			, {1305, -8, -7, 84}, {1822, -7, -11, 84}, {1305, -12, -11, 84}// 142	143	144	
			, {1822, -14, -7, 60}, {1822, -6, -11, 60}, {2880, -8, -10, 94}// 145	146	147	
			, {88, -5, -14, 64}, {1822, -6, -7, 60}, {1305, -14, -8, 65}// 148	149	150	
			, {1822, -6, -8, 60}, {1305, -8, -9, 84}, {1305, -8, -11, 84}// 151	152	153	
			, {1305, -7, -7, 84}, {1305, -6, -9, 84}, {1305, -7, -13, 84}// 154	155	156	
			, {1305, -8, -8, 84}, {1305, -8, -13, 84}, {1822, -13, -11, 60}// 157	158	159	
			, {1305, -14, -11, 65}, {1822, -10, -11, 60}, {105, -13, -14, 84}// 160	161	162	
			, {1822, -6, -13, 89}, {2880, -8, -11, 94}, {1305, -6, -10, 84}// 163	164	165	
			, {1822, -10, -7, 60}, {88, -6, -14, 64}, {1305, -15, -8, 65}// 166	167	168	
			, {1823, -5, -12, 84}, {1822, -7, -10, 89}, {1305, -12, -13, 65}// 169	170	171	
			, {1865, -10, -13, 89}, {1305, -10, -7, 65}, {88, -12, -14, 64}// 172	173	174	
			, {1305, -10, -10, 65}, {1305, -9, -9, 84}, {90, -16, -14, 84}// 175	176	177	
			, {1822, -8, -10, 89}, {1822, -8, -13, 84}, {87, -5, -11, 63}// 178	179	180	
			, {4635, -12, -11, 84}, {1822, -7, -12, 89}, {1822, -5, -13, 84}// 181	182	183	
			, {1822, -7, -10, 84}, {87, -16, -10, 64}, {1822, -11, -11, 60}// 184	185	187	
			, {1305, -11, -11, 84}, {1305, -15, -7, 65}, {105, -6, -14, 84}// 188	189	190	
			, {1822, -12, -8, 60}, {1305, -13, -13, 65}, {1305, -10, -10, 84}// 191	192	193	
			, {1305, -6, -12, 84}, {1305, -15, -12, 84}, {88, -15, -12, 64}// 194	195	196	
			, {6426, -10, -12, 63}, {1822, -7, -13, 89}, {1305, -12, -7, 65}// 197	198	199	
			, {1822, -6, -12, 60}, {1305, -5, -8, 84}, {1305, -11, -10, 84}// 200	201	202	
			, {1305, -14, -9, 84}, {1305, -8, -11, 65}, {4634, -13, -10, 84}// 203	204	205	
			, {1822, -5, -11, 60}, {1305, -7, -10, 84}, {1305, -8, -12, 65}// 206	207	208	
			, {1305, -9, -7, 65}, {87, -16, -13, 64}, {4632, -14, -13, 84}// 209	210	211	
			, {1305, -15, -12, 65}, {1822, -10, -12, 60}, {1822, -12, -12, 60}// 213	214	215	
			, {1305, -11, -13, 84}, {1305, -12, -8, 65}, {1305, -12, -12, 84}// 216	217	218	
			, {1822, -14, -9, 60}, {87, -16, -11, 64}, {1822, -14, -11, 60}// 219	220	221	
			, {1822, -14, -12, 60}, {1305, -12, -10, 65}, {1822, -15, -9, 60}// 222	223	224	
			, {1305, -15, -10, 84}, {1822, -11, -9, 60}, {1822, -5, -8, 60}// 225	226	227	
			, {2762, -9, -13, 94}, {1822, -5, -13, 60}, {4634, -8, -9, 94}// 228	229	230	
			, {1822, -7, -9, 89}, {88, -9, -12, 63}, {2885, -9, -9, 84}// 231	232	233	
			, {1305, -9, -12, 84}, {1822, -10, -8, 60}, {1305, -7, -12, 84}// 234	235	236	
			, {1305, -11, -8, 84}, {105, -5, -14, 84}, {1305, -10, -9, 65}// 237	238	239	
			, {1823, -10, -12, 84}, {1305, -9, -13, 84}, {105, -11, -14, 84}// 240	241	242	
			, {1305, -9, -8, 84}, {1305, -11, -7, 65}, {2974, -12, -11, 65}// 243	244	245	
			, {2766, -8, -13, 94}, {1822, -14, -10, 60}, {88, -13, -12, 64}// 246	247	248	
			, {1822, -15, -12, 60}, {1822, -8, -12, 84}, {1305, -5, -9, 84}// 249	250	251	
			, {87, -5, -7, 63}, {1822, -15, -11, 60}, {1822, -6, -11, 84}// 252	253	254	
			, {1305, -13, -11, 65}, {1305, -14, -7, 65}, {1822, -9, -10, 84}// 255	256	257	
			, {1822, -9, -13, 60}, {1822, -9, -12, 60}, {1822, -9, -11, 60}// 258	259	260	
			, {1822, -9, -10, 60}, {1822, -9, -9, 60}, {1822, -9, -8, 60}// 261	262	263	
			, {1822, -9, -7, 60}, {1305, -14, -10, 65}, {1822, -8, -13, 60}// 264	265	266	
			, {1822, -8, -12, 60}, {1822, -8, -11, 60}, {1822, -8, -10, 60}// 267	268	269	
			, {1822, -8, -9, 60}, {1822, -8, -8, 60}, {1822, -8, -7, 60}// 270	271	272	
			, {1822, -7, -13, 60}, {1822, -7, -12, 60}, {1822, -7, -11, 60}// 273	274	275	
			, {1822, -7, -10, 60}, {1822, -7, -9, 60}, {1822, -7, -8, 60}// 276	277	278	
			, {1822, -7, -7, 60}, {87, -16, -12, 64}, {1305, -8, -10, 65}// 279	280	281	
			, {1305, -8, -9, 65}, {1305, -8, -8, 65}, {1305, -8, -7, 65}// 282	283	284	
			, {1305, -7, -13, 65}, {1305, -7, -12, 65}, {1305, -7, -11, 65}// 285	286	287	
			, {1305, -7, -10, 65}, {1305, -7, -9, 65}, {1305, -7, -8, 65}// 288	289	290	
			, {1305, -7, -7, 65}, {1305, -6, -13, 65}, {1305, -6, -12, 65}// 291	292	293	
			, {1305, -6, -11, 65}, {1305, -6, -10, 65}, {1305, -6, -9, 65}// 294	295	296	
			, {1305, -6, -8, 65}, {1305, -6, -7, 65}, {1305, -5, -13, 65}// 297	298	299	
			, {1305, -5, -12, 65}, {1305, -5, -11, 65}, {1305, -5, -10, 65}// 300	301	302	
			, {1305, -5, -9, 65}, {1305, -5, -8, 65}, {1305, -5, -7, 65}// 303	304	305	
			, {87, -16, -8, 64}, {87, -16, -7, 64}, {1305, -9, -11, 84}// 306	307	308	
			, {1822, -7, -12, 84}, {1305, -14, -11, 84}, {6426, -11, -12, 63}// 309	310	311	
			, {1822, -8, -10, 84}, {2878, -13, -8, 64}, {4634, -14, -10, 84}// 312	313	314	
			, {1822, -9, -10, 89}, {1822, -7, -9, 84}, {1822, -6, -13, 84}// 315	316	317	
			, {88, -6, -12, 63}, {1782, -5, -9, 64}, {1305, -15, -8, 84}// 318	319	320	
			, {1822, -8, -9, 84}, {1822, -9, -13, 84}, {1305, -5, -11, 84}// 321	322	323	
			, {105, -7, -14, 84}, {1305, -6, -11, 84}, {2880, -12, -8, 64}// 324	325	326	
			, {2768, -7, -9, 94}, {2885, -6, -9, 84}, {1305, -9, -10, 84}// 327	328	329	
			, {1305, -6, -8, 84}, {1305, -5, -7, 84}, {2768, -8, -9, 94}// 330	331	332	
			, {1305, -5, -12, 84}, {105, -10, -14, 84}, {105, -14, -14, 84}// 333	334	335	
			, {4031, -11, -12, 76}, {1305, -10, -9, 84}, {1305, -12, -10, 84}// 336	337	338	
			, {1305, -9, -7, 84}, {1305, -14, -7, 84}, {1822, -9, -12, 89}// 339	340	341	
			, {105, -12, -14, 84}, {1305, -6, -13, 84}, {1305, -11, -7, 84}// 342	343	344	
			, {1305, -13, -10, 84}, {1305, -13, -9, 84}, {1305, -13, -8, 84}// 345	346	347	
			, {1305, -13, -7, 84}, {1305, -12, -13, 84}, {106, -16, -7, 84}// 348	349	350	
			, {106, -16, -8, 84}, {106, -16, -9, 84}, {106, -16, -10, 84}// 351	352	353	
			, {106, -16, -12, 84}, {106, -16, -13, 84}, {1822, -9, -12, 84}// 354	355	356	
			, {2766, -7, -13, 94}, {1822, -6, -12, 89}, {1305, -12, -8, 84}// 357	358	359	
			, {1305, -12, -7, 84}, {1305, -13, -11, 84}, {1822, -7, -13, 84}// 360	361	362	
			, {4634, -7, -9, 94}, {1822, -10, -13, 84}, {2880, -7, -10, 94}// 363	364	365	
			, {1822, -6, -10, 84}, {2760, -7, -12, 94}, {1822, -6, -11, 89}// 366	367	368	
			, {1822, -6, -10, 89}, {4633, -9, -11, 94}, {1846, -5, -13, 89}// 369	370	371	
			, {4632, -7, -12, 94}, {2758, -8, -12, 94}, {2764, -6, -13, 94}// 373	374	376	
			, {4635, -6, -11, 94}, {2758, -8, -10, 94}, {2758, -7, -11, 94}// 377	378	379	
			, {2760, -7, -10, 94}, {2767, -6, -11, 94}, {2761, -6, -9, 94}// 380	381	382	
			, {2765, -9, -12, 94}, {2760, -8, -11, 94}, {2763, -9, -9, 94}// 383	384	385	
			, {2767, -6, -12, 94}, {4554, -15, -8, 65}, {2765, -9, -10, 94}// 386	387	388	
			, {2765, -9, -11, 94}, {2767, -6, -10, 94}, {1822, -13, -2, 60}// 389	390	391	
			, {1305, -7, -1, 84}, {1305, -14, -2, 84}, {1305, -11, -6, 84}// 392	393	394	
			, {1822, -13, -4, 60}, {1822, -9, -1, 60}, {1305, -10, -1, 84}// 395	396	397	
			, {1822, -11, -5, 60}, {1305, -15, -5, 65}, {1305, -12, -5, 84}// 398	399	400	
			, {1305, -13, -4, 65}, {90, -6, -1, 84}, {1822, -14, -3, 70}// 401	402	403	
			, {1822, -14, -3, 75}, {105, -11, -1, 84}, {1305, -15, -4, 84}// 404	405	406	
			, {1305, -15, -3, 65}, {1822, -13, -1, 60}, {1846, -13, -3, 75}// 407	408	409	
			, {1822, -11, -2, 60}, {88, -6, -1, 64}, {1822, -13, -4, 70}// 410	411	412	
			, {1305, -9, -3, 84}, {1822, -5, -1, 63}, {1822, -12, -6, 60}// 413	414	415	
			, {1305, -13, -6, 65}, {88, -13, -1, 64}, {1305, -9, -1, 84}// 416	417	418	
			, {1822, -6, -4, 60}, {106, -6, -5, 84}, {88, -10, -1, 64}// 419	420	421	
			, {1305, -14, -5, 84}, {1822, -15, -6, 60}, {1822, -13, -3, 70}// 423	424	425	
			, {1846, -11, -4, 65}, {1822, -15, -3, 60}, {1305, -14, -4, 65}// 426	427	428	
			, {1305, -10, -6, 65}, {1822, -6, -2, 60}, {105, -5, -6, 84}// 429	430	431	
			, {1822, -15, -1, 60}, {1305, -9, -4, 84}, {1822, -15, -2, 60}// 432	433	434	
			, {1822, -13, -4, 65}, {88, -11, -1, 64}, {1305, -14, -2, 65}// 435	436	437	
			, {88, -7, -1, 64}, {1822, -13, -3, 65}, {1305, -12, -6, 65}// 438	439	440	
			, {1822, -7, -1, 60}, {1305, -14, -5, 65}, {105, -8, -1, 84}// 441	442	443	
			, {1822, -11, -4, 60}, {1822, -12, -2, 60}, {1822, -12, -3, 60}// 444	445	446	
			, {3606, -8, -3, 90}, {1305, -12, -4, 65}, {1822, -14, -1, 60}// 447	448	449	
			, {87, -16, -3, 64}, {1305, -6, -6, 84}, {89, -5, -6, 63}// 450	451	452	
			, {1305, -15, -5, 84}, {1305, -13, -5, 65}, {1822, -14, -6, 60}// 453	454	455	
			, {1305, -12, -2, 84}, {8612, -10, -3, 84}, {1846, -12, -4, 70}// 456	457	458	
			, {1822, -11, -3, 60}, {1305, -6, -2, 84}, {105, -13, -1, 84}// 459	460	461	
			, {1305, -11, -6, 65}, {1305, -14, -6, 65}, {2880, -8, -3, 84}// 462	463	464	
			, {1305, -9, -6, 65}, {1305, -13, -1, 84}, {90, -6, -6, 63}// 465	466	467	
			, {105, -9, -1, 84}, {1305, -6, -1, 84}, {1305, -15, -2, 65}// 468	469	470	
			, {1822, -6, -3, 60}, {1822, -10, -1, 60}, {105, -6, -1, 84}// 471	472	473	
			, {1846, -14, -3, 80}, {1822, -12, -3, 65}, {1822, -14, -3, 65}// 474	475	476	
			, {88, -9, -1, 64}, {1846, -5, -2, 60}, {1822, -14, -4, 75}// 477	478	479	
			, {1305, -9, -2, 84}, {1822, -6, -6, 60}, {1305, -15, -4, 65}// 480	481	483	
			, {1305, -13, -6, 84}, {1822, -13, -6, 60}, {1305, -14, -1, 65}// 484	485	486	
			, {105, -7, -1, 84}, {1305, -13, -2, 84}, {1305, -8, -5, 84}// 487	488	490	
			, {1846, -5, -3, 60}, {1305, -12, -3, 65}, {1822, -12, -1, 60}// 491	492	493	
			, {105, -13, -5, 84}, {1305, -13, -3, 65}, {105, -14, -1, 84}// 494	495	496	
			, {1305, -13, -2, 65}, {1305, -13, -1, 65}, {3605, -8, -3, 90}// 497	498	500	
			, {1305, -8, -4, 84}, {1846, -5, -4, 60}, {1305, -15, -1, 65}// 501	502	503	
			, {105, -12, -1, 84}, {4634, -8, -2, 84}, {1305, -6, -4, 84}// 504	505	506	
			, {1822, -6, -1, 60}, {1305, -8, -2, 84}, {1822, -15, -4, 60}// 507	508	509	
			, {1305, -6, -5, 84}, {8071, -8, -3, 92}, {88, -14, -1, 64}// 510	511	512	
			, {1822, -5, -6, 60}, {105, -15, -1, 84}, {1822, -13, -3, 60}// 513	514	515	
			, {1822, -14, -4, 60}, {1305, -12, -5, 65}, {1305, -11, -1, 84}// 516	517	518	
			, {1822, -14, -2, 60}, {1305, -8, -3, 84}, {1822, -13, -5, 60}// 519	520	521	
			, {88, -8, -1, 64}, {1822, -12, -4, 60}, {1822, -6, -5, 60}// 522	523	524	
			, {1846, -13, -4, 75}, {87, -16, -2, 64}, {1305, -12, -2, 65}// 525	526	527	
			, {1822, -14, -5, 60}, {1822, -12, -4, 65}, {1822, -5, -5, 63}// 528	529	530	
			, {1305, -7, -2, 84}, {1822, -11, -1, 60}, {88, -15, -1, 64}// 531	532	533	
			, {1305, -15, -6, 65}, {90, -6, -6, 84}, {1305, -8, -6, 84}// 534	535	536	
			, {1305, -7, -3, 84}, {1822, -14, -3, 60}, {1822, -8, -1, 60}// 537	538	539	
			, {1305, -14, -6, 84}, {1846, -12, -3, 70}, {1822, -11, -6, 60}// 540	541	542	
			, {90, -16, -1, 84}, {87, -16, -1, 64}, {1822, -12, -5, 60}// 543	544	545	
			, {1822, -15, -5, 60}, {4554, -10, -4, 84}, {1305, -12, -1, 65}// 546	547	548	
			, {1846, -14, -4, 80}, {1305, -7, -4, 84}, {1305, -12, -1, 84}// 549	550	551	
			, {1822, -14, -4, 65}, {1822, -10, -6, 60}, {1822, -10, -5, 60}// 552	553	554	
			, {1822, -10, -4, 60}, {1822, -10, -3, 60}, {1822, -10, -2, 60}// 555	556	557	
			, {1822, -9, -6, 60}, {1822, -9, -5, 60}, {1822, -9, -4, 60}// 558	559	560	
			, {1822, -9, -3, 60}, {1822, -9, -2, 60}, {1822, -8, -6, 60}// 561	562	563	
			, {1822, -8, -5, 60}, {1822, -8, -4, 60}, {1822, -8, -3, 60}// 564	565	566	
			, {1822, -8, -2, 60}, {1822, -7, -6, 60}, {1822, -7, -5, 60}// 567	568	569	
			, {1822, -7, -4, 60}, {1822, -7, -3, 60}, {1822, -7, -2, 60}// 570	571	572	
			, {1305, -10, -6, 84}, {1305, -14, -3, 65}, {8612, -10, -5, 84}// 573	574	575	
			, {1305, -8, -6, 65}, {1305, -7, -6, 65}, {1305, -6, -6, 65}// 576	577	578	
			, {1305, -5, -6, 65}, {87, -16, -6, 64}, {87, -16, -5, 64}// 579	580	581	
			, {87, -16, -4, 64}, {1846, -11, -3, 65}, {1305, -12, -6, 84}// 582	583	584	
			, {1305, -11, -5, 65}, {1305, -11, -4, 65}, {1305, -11, -3, 65}// 585	586	587	
			, {1305, -11, -2, 65}, {1305, -11, -1, 65}, {1305, -10, -5, 65}// 588	589	590	
			, {1305, -10, -4, 65}, {1305, -10, -3, 65}, {1305, -10, -2, 65}// 591	592	593	
			, {1305, -10, -1, 65}, {1305, -9, -5, 65}, {1305, -9, -4, 65}// 594	595	596	
			, {1305, -9, -3, 65}, {1305, -9, -2, 65}, {1305, -9, -1, 65}// 597	598	599	
			, {1305, -8, -5, 65}, {1305, -8, -4, 65}, {1305, -8, -3, 65}// 600	601	602	
			, {1305, -8, -2, 65}, {1305, -8, -1, 65}, {1305, -7, -5, 65}// 603	604	605	
			, {1305, -7, -4, 65}, {1305, -7, -3, 65}, {1305, -7, -2, 65}// 606	607	608	
			, {1305, -7, -1, 65}, {1305, -6, -5, 65}, {1305, -6, -4, 65}// 609	610	611	
			, {1305, -6, -3, 65}, {1305, -6, -2, 65}, {1305, -6, -1, 65}// 612	613	614	
			, {1305, -11, -2, 84}, {1305, -11, -5, 84}, {1822, -14, -4, 70}// 616	617	618	
			, {1305, -10, -3, 84}, {105, -10, -1, 84}, {88, -12, -1, 64}// 619	620	621	
			, {1305, -13, -5, 84}, {1305, -7, -5, 84}, {1305, -15, -6, 84}// 622	623	624	
			, {1305, -7, -6, 84}, {4632, -8, -4, 84}, {1305, -9, -5, 84}// 625	626	627	
			, {1305, -5, -6, 84}, {106, -6, -3, 84}, {106, -6, -4, 84}// 628	629	630	
			, {106, -6, -2, 84}, {106, -6, -1, 84}, {1305, -15, -1, 84}// 631	632	633	
			, {1305, -8, -1, 84}, {1305, -6, -3, 84}, {1305, -10, -2, 84}// 634	635	636	
			, {1305, -9, -6, 84}, {1305, -15, -2, 84}, {1305, -15, -3, 84}// 637	638	639	
			, {105, -11, -5, 84}, {1305, -10, -5, 84}, {106, -16, -2, 84}// 640	641	642	
			, {106, -16, -3, 84}, {106, -16, -4, 84}, {106, -16, -5, 84}// 643	644	645	
			, {106, -16, -6, 84}, {1305, -10, -4, 84}, {1305, -14, -1, 84}// 646	647	648	
			, {105, -12, -5, 84}, {106, -10, -3, 95}, {106, -10, -2, 95}// 650	651	652	
			, {8612, -10, -2, 84}, {1822, -5, 13, 5}, {1822, -7, 10, 5}// 653	654	657	
			, {2880, -2, -11, 84}, {106, 1, -10, 84}, {1305, -3, -9, 84}// 659	660	661	
			, {1822, -1, -11, 60}, {87, 1, -8, 64}, {87, 1, -13, 64}// 662	663	664	
			, {1305, -2, -12, 84}, {1822, 0, -8, 60}, {1305, -1, -9, 84}// 665	666	667	
			, {88, 0, -14, 64}, {1305, 1, -11, 84}, {106, 1, -12, 84}// 668	669	670	
			, {1305, 0, -10, 84}, {1305, 0, -7, 84}, {1305, -3, -12, 84}// 671	672	673	
			, {1305, -4, -10, 84}, {1822, -4, -9, 60}, {1305, -4, -12, 84}// 674	675	676	
			, {88, -3, -14, 64}, {1305, -4, -13, 84}, {1822, 1, -13, 60}// 677	678	679	
			, {1822, -2, -13, 60}, {1822, -1, -8, 60}, {88, 1, -14, 64}// 680	681	682	
			, {1822, -3, -10, 60}, {88, -2, -14, 64}, {1822, -1, -12, 60}// 683	684	685	
			, {1822, -3, -7, 60}, {1822, 0, -9, 60}, {105, -4, -14, 84}// 686	687	688	
			, {1305, 1, -12, 84}, {1822, -3, -8, 60}, {1305, -2, -10, 84}// 689	690	691	
			, {2880, -1, -12, 84}, {1822, -4, -10, 60}, {88, -4, -14, 64}// 692	693	694	
			, {4632, -1, -13, 84}, {1822, -2, -12, 60}, {1305, -4, -11, 84}// 695	696	697	
			, {3648, -1, -12, 68}, {1305, -3, -8, 84}, {1822, 0, -13, 60}// 698	699	700	
			, {1305, 0, -8, 84}, {2880, -1, -8, 64}, {1822, -2, -8, 60}// 701	702	703	
			, {87, 1, -7, 64}, {4633, -3, -11, 84}, {1822, -2, -11, 60}// 704	705	706	
			, {1822, 1, -11, 60}, {87, 1, -10, 64}, {1822, -4, -13, 60}// 707	708	709	
			, {87, 1, -12, 64}, {2878, -2, -13, 64}, {1305, -1, -13, 84}// 710	711	712	
			, {88, -1, -14, 64}, {1305, -3, -10, 84}, {3648, -1, -8, 68}// 713	714	715	
			, {1822, -4, -8, 60}, {87, 1, -11, 64}, {1822, 1, -7, 60}// 716	717	718	
			, {1822, 0, -7, 60}, {1305, -1, -11, 84}, {1822, -3, -9, 60}// 719	720	721	
			, {105, 0, -14, 84}, {1305, 0, -9, 84}, {4635, 0, -11, 84}// 722	723	724	
			, {1305, -2, -7, 84}, {1822, -4, -12, 60}, {87, 1, -9, 64}// 725	726	727	
			, {1822, 0, -10, 60}, {1305, -4, -8, 84}, {106, 1, -9, 84}// 728	729	730	
			, {3648, -1, -10, 68}, {1822, -2, -10, 60}, {105, -2, -14, 84}// 731	732	733	
			, {1822, 1, -12, 60}, {1822, -1, -10, 60}, {1822, -3, -13, 60}// 734	735	736	
			, {3648, -1, -11, 68}, {1822, -3, -11, 60}, {2878, -1, -10, 64}// 737	738	739	
			, {105, -1, -14, 84}, {2878, -1, -9, 64}, {3649, -1, -13, 70}// 740	741	742	
			, {3649, -3, -13, 70}, {1822, -4, -11, 60}, {1822, -3, -12, 60}// 743	744	745	
			, {105, 1, -14, 84}, {1822, -1, -7, 60}, {1822, 1, -8, 60}// 746	747	748	
			, {4635, 0, -12, 84}, {1822, -4, -7, 60}, {1305, -2, -11, 84}// 749	750	751	
			, {1822, -1, -13, 60}, {1305, 1, -8, 84}, {1822, 1, -9, 60}// 752	753	754	
			, {3648, -1, -9, 68}, {1822, 1, -10, 60}, {1305, 0, -13, 84}// 755	756	757	
			, {1822, -2, -7, 60}, {1305, -1, -12, 84}, {1822, 0, -11, 60}// 758	759	760	
			, {2880, -2, -12, 84}, {1822, -1, -9, 60}, {1822, -2, -9, 60}// 761	762	763	
			, {1305, -2, -9, 84}, {1305, -4, -9, 84}, {1305, -1, -7, 84}// 764	765	766	
			, {106, 1, -13, 84}, {1822, 0, -12, 60}, {2880, -3, -13, 64}// 767	768	769	
			, {1305, 1, -13, 84}, {1305, -2, -8, 84}, {90, 1, -14, 84}// 770	771	772	
			, {2880, -1, -11, 84}, {2880, -1, -13, 64}, {1305, -4, -13, 65}// 773	774	775	
			, {1305, -4, -12, 65}, {1305, -4, -11, 65}, {1305, -4, -10, 65}// 776	777	778	
			, {1305, -4, -9, 65}, {1305, -4, -8, 65}, {1305, -4, -7, 65}// 779	780	781	
			, {1305, -3, -13, 65}, {1305, -3, -12, 65}, {1305, -3, -11, 65}// 782	783	784	
			, {1305, -3, -10, 65}, {1305, -3, -9, 65}, {1305, -3, -8, 65}// 785	786	787	
			, {1305, -3, -7, 65}, {1305, -2, -13, 65}, {1305, -2, -12, 65}// 788	789	790	
			, {1305, -2, -11, 65}, {1305, -2, -10, 65}, {1305, -2, -9, 65}// 791	792	793	
			, {1305, -2, -8, 65}, {1305, -2, -7, 65}, {1305, -1, -13, 65}// 794	795	796	
			, {1305, -1, -12, 65}, {1305, -1, -11, 65}, {1305, -1, -10, 65}// 797	798	799	
			, {1305, -1, -9, 65}, {1305, -1, -8, 65}, {1305, -1, -7, 65}// 800	801	802	
			, {1305, 0, -13, 65}, {1305, 0, -12, 65}, {1305, 0, -11, 65}// 803	804	805	
			, {1305, 0, -10, 65}, {1305, 0, -9, 65}, {1305, 0, -8, 65}// 806	807	808	
			, {1305, 0, -7, 65}, {1305, 1, -13, 65}, {1305, 1, -12, 65}// 809	810	811	
			, {1305, 1, -11, 65}, {1305, 1, -10, 65}, {1305, 1, -9, 65}// 812	813	814	
			, {1305, 1, -8, 65}, {1305, 1, -7, 65}, {105, -3, -14, 84}// 815	816	817	
			, {3649, -2, -13, 70}, {1305, 0, -12, 84}, {1305, -2, -13, 84}// 818	819	820	
			, {2878, -1, -12, 64}, {1305, 1, -9, 84}, {2878, -1, -11, 64}// 821	822	823	
			, {1305, -4, -7, 84}, {4632, -2, -13, 84}, {1305, -1, -10, 84}// 824	825	826	
			, {1305, 1, -10, 84}, {4634, -2, -10, 84}, {1305, -3, -7, 84}// 827	828	829	
			, {1305, -3, -13, 84}, {1305, 1, -7, 84}, {1305, 0, -11, 84}// 830	831	832	
			, {106, 1, -7, 84}, {106, 1, -8, 84}, {1305, -1, -8, 84}// 833	834	835	
			, {106, 1, -11, 84}, {1305, -3, -11, 84}, {4633, -3, -12, 84}// 836	837	838	
			, {4634, -1, -10, 84}, {4554, -4, -11, 65}, {4554, -4, -8, 65}// 839	840	841	
			, {2, 8, -1, 45}, {1822, 2, 2, 40}, {1822, 7, 4, 38}// 842	843	844	
			, {1953, 7, 3, 30}, {1822, 11, -4, 40}, {1822, 2, -2, 40}// 845	846	847	
			, {1822, 8, 4, 10}, {99, 2, -6, 45}, {1822, 11, 7, 15}// 848	849	851	
			, {2861, 7, -5, 45}, {1823, 10, 3, 35}, {1822, 10, -4, 40}// 852	853	854	
			, {1846, 5, 3, 40}, {1822, 11, 6, 5}, {99, 4, -6, 45}// 855	856	857	
			, {105, -3, -6, 84}, {1822, 9, 9, 15}, {1822, 4, 0, 40}// 858	859	860	
			, {1822, 2, -4, 40}, {1822, 11, 2, 5}, {105, -4, -6, 84}// 861	862	863	
			, {1822, 10, 7, 15}, {1822, 11, 3, 5}, {1822, 8, -3, 40}// 864	865	866	
			, {3, 8, -2, 45}, {1846, -3, -4, 50}, {1822, 8, 0, 40}// 867	868	869	
			, {1822, 4, 1, 40}, {1871, 10, 7, 20}, {1822, 1, -2, 40}// 870	871	872	
			, {1822, 3, -2, 40}, {100, 0, 3, 45}, {1822, 8, 4, 10}// 874	876	877	
			, {1846, -2, -2, 45}, {2166, 11, 3, 35}, {1822, 4, -2, 40}// 878	879	880	
			, {1822, 10, 0, 40}, {1822, -3, -1, 53}, {89, 1, -6, 64}// 881	882	883	
			, {2861, 6, -5, 45}, {1822, 2, -3, 40}, {1823, 11, 4, 30}// 884	885	886	
			, {1846, -4, -2, 55}, {1822, 11, -5, 40}, {1867, 10, 1, 40}// 887	888	889	
			, {105, 1, -6, 84}, {1822, 9, -5, 40}, {1822, 11, 2, 35}// 890	892	893	
			, {1822, 7, -4, 40}, {1822, 9, -3, 40}, {1822, 10, 2, 10}// 894	895	896	
			, {1822, 1, -1, 40}, {1822, 2, -5, 40}, {1822, 10, -5, 40}// 897	898	899	
			, {1823, 10, 4, 30}, {1822, 3, -5, 40}, {1822, 1, 1, 40}// 900	901	902	
			, {100, 0, 1, 45}, {1822, 10, -1, 40}, {1822, 7, -5, 40}// 903	904	905	
			, {1822, -1, -3, 40}, {1822, 11, -1, 40}, {88, 0, -6, 64}// 906	908	909	
			, {1822, -1, -6, 60}, {99, 6, -6, 45}, {2860, 11, -3, 45}// 910	911	912	
			, {1822, -2, -5, 48}, {1822, 10, 1, 10}, {1822, 11, 3, 10}// 913	915	916	
			, {1822, 6, -2, 40}, {1822, 10, 2, 35}, {99, 3, -6, 45}// 917	918	919	
			, {1822, 11, 4, 5}, {1822, 10, 3, 5}, {1823, 10, 5, 25}// 920	921	922	
			, {1822, 6, -1, 40}, {90, 1, -6, 84}, {1822, 0, -4, 40}// 924	925	926	
			, {1822, 9, -2, 40}, {1822, 10, 3, 10}, {1822, 7, -1, 40}// 927	928	929	
			, {1822, 4, -5, 40}, {1846, 5, 2, 40}, {2861, 3, -5, 45}// 930	931	932	
			, {1822, -4, -5, 58}, {1822, 11, 0, 40}, {1822, 10, 2, 5}// 933	934	935	
			, {1822, 11, -3, 40}, {1822, 0, -2, 40}, {1823, 6, 1, 40}// 936	937	938	
			, {1953, 8, 4, 30}, {1822, 3, -4, 40}, {1822, 2, 1, 40}// 939	940	941	
			, {2860, 11, -4, 45}, {1822, 4, 2, 40}, {1822, 1, 0, 40}// 942	943	944	
			, {1822, 11, 1, 5}, {1822, 8, -5, 40}, {1823, 11, 8, 15}// 945	946	947	
			, {1822, 5, -2, 40}, {1846, -4, -4, 55}, {1822, 11, 5, 5}// 948	949	951	
			, {1822, 7, 0, 40}, {1822, 1, 3, 40}, {1823, 11, 9, 10}// 952	953	954	
			, {1822, 11, 1, 35}, {1822, 11, 7, 5}, {1846, -2, -4, 45}// 955	956	957	
			, {1823, 11, 6, 20}, {1822, 1, -3, 40}, {1822, 8, 5, 5}// 959	960	961	
			, {1822, 5, 0, 40}, {105, -2, -6, 84}, {1822, 10, 5, 5}// 962	963	964	
			, {2861, 9, -5, 45}, {1822, 5, -5, 40}, {1822, 10, 6, 5}// 965	966	967	
			, {1822, 1, 2, 40}, {1822, 11, 8, 10}, {1822, 4, -1, 40}// 968	969	970	
			, {1823, 9, 3, 35}, {1822, 11, 6, 10}, {1822, 9, 0, 40}// 972	973	974	
			, {1822, 9, 6, 28}, {1822, -3, -6, 60}, {1822, 10, 7, 5}// 975	976	977	
			, {1822, 11, 2, 10}, {1822, -1, -2, 40}, {1822, 4, -4, 40}// 978	979	980	
			, {1822, 10, 5, 10}, {1822, 10, 4, 10}, {1822, 8, 5, 10}// 981	982	983	
			, {100, 0, 0, 45}, {1846, -4, -3, 55}, {1822, 11, 7, 10}// 984	985	986	
			, {1822, -3, -5, 53}, {1822, 10, 8, 5}, {1822, 3, 0, 40}// 987	988	989	
			, {2860, 11, 0, 45}, {1822, 10, 8, 10}, {88, -4, -6, 64}// 990	991	992	
			, {1822, 5, -1, 40}, {1822, 11, 1, 10}, {1822, 11, -2, 40}// 993	994	997	
			, {1822, 3, 2, 40}, {1822, 11, 2, 15}, {1822, 9, -4, 40}// 998	999	1000	
			, {1846, 6, 3, 35}, {1822, 8, 4, 5}, {1822, 6, 3, 5}// 1001	1002	1003	
			, {1305, -4, -6, 84}, {1822, 10, -3, 40}, {1822, 11, 5, 10}// 1004	1005	1006	
			, {2861, 10, -5, 45}, {1822, 9, 7, 23}, {88, -3, -6, 64}// 1007	1008	1009	
			, {88, -2, -6, 64}, {1822, 0, -3, 40}, {1822, -4, -6, 60}// 1010	1012	1013	
			, {1822, 11, 1, 40}, {99, 7, -6, 45}, {1822, 3, -3, 40}// 1014	1015	1016	
			, {1822, 4, -3, 40}, {1822, 11, 8, 5}, {2861, 2, 2, 45}// 1017	1019	1022	
			, {1822, 10, 9, 18}, {1822, 7, -3, 40}, {1822, 1, -4, 40}// 1024	1025	1026	
			, {1822, 10, 6, 10}, {1822, 10, 7, 10}, {1823, 8, 3, 35}// 1027	1028	1029	
			, {1822, 2, 3, 40}, {1822, 2, 0, 40}, {2861, 4, -5, 45}// 1030	1031	1032	
			, {99, 9, -6, 45}, {1822, 9, -1, 40}, {1822, 3, 3, 40}// 1033	1034	1035	
			, {1822, 5, -3, 40}, {1822, 11, 9, 5}, {1823, 8, 1, 40}// 1036	1037	1038	
			, {1822, 5, -4, 40}, {1822, 6, -4, 40}, {1822, 5, 4, 43}// 1039	1040	1041	
			, {1822, -1, -4, 40}, {1822, 8, 5, 33}, {1822, 9, 8, 18}// 1042	1043	1044	
			, {1822, 8, -4, 40}, {1822, 2, -1, 40}, {1822, 6, -3, 40}// 1045	1046	1047	
			, {1846, -3, -2, 50}, {1822, 4, 3, 40}, {1822, -2, -1, 48}// 1048	1049	1050	
			, {1822, 3, -1, 40}, {1822, 7, -2, 40}, {1822, 10, -2, 40}// 1051	1052	1053	
			, {2860, 11, -1, 45}, {1822, 11, 4, 10}, {2861, 3, 2, 45}// 1054	1055	1056	
			, {1822, 0, -6, 60}, {102, 1, -6, 45}, {99, 10, -6, 45}// 1057	1058	1059	
			, {1822, 6, -5, 40}, {1822, 10, 4, 5}, {1822, 8, -1, 40}// 1060	1061	1062	
			, {1822, 8, -2, 40}, {1822, 10, 1, 5}, {99, -1, -2, 45}// 1063	1064	1065	
			, {1822, 10, 6, 15}, {1846, -3, -3, 50}, {1846, -2, -3, 45}// 1066	1067	1068	
			, {1822, 6, 0, 40}, {99, 8, -6, 45}, {1822, -4, -1, 58}// 1069	1070	1071	
			, {2016, 9, 5, 25}, {1822, 3, 1, 40}, {1822, 1, -6, 60}// 1072	1073	1074	
			, {1823, 9, 4, 30}, {1822, -2, -6, 60}, {2860, 1, 0, 45}// 1075	1076	1077	
			, {1869, 10, 8, 15}, {1823, 9, 1, 40}, {1822, 11, 5, 15}// 1078	1079	1080	
			, {99, 0, -2, 45}, {99, 5, -6, 45}, {1822, 5, 1, 5}// 1082	1083	1084	
			, {100, 0, 2, 45}, {1305, -4, -6, 65}, {1305, -3, -6, 65}// 1086	1087	1088	
			, {1305, -2, -6, 65}, {1305, -1, -6, 65}, {1305, 0, -6, 65}// 1089	1090	1091	
			, {1305, 1, -6, 65}, {1305, 1, -6, 84}, {1822, 10, 3, 15}// 1092	1093	1094	
			, {1305, 0, -6, 84}, {1305, -3, -6, 84}, {1953, 5, 1, 40}// 1097	1098	1099	
			, {88, -1, -6, 64}, {1823, 7, 2, 35}, {100, 0, -1, 45}// 1100	1101	1102	
			, {99, 0, -5, 45}, {101, 1, -5, 45}, {99, 1, 3, 45}// 1103	1104	1105	
			, {99, 2, 3, 45}, {99, 4, 3, 45}, {1305, -1, -6, 84}// 1106	1107	1108	
			, {1823, 7, 1, 40}, {1822, 11, 2, 20}, {99, 3, 3, 45}// 1109	1110	1111	
			, {1953, 6, 2, 35}, {1822, 10, 1, 35}, {99, -1, -5, 45}// 1112	1113	1116	
			, {2860, 1, 1, 45}, {1822, 6, 4, 38}, {1305, -2, -6, 84}// 1117	1118	1119	
			, {105, -1, -6, 84}, {99, 11, -6, 45}, {106, 1, -6, 84}// 1120	1121	1122	
			, {1822, 11, 6, 15}, {1953, 10, 6, 20}, {1822, 9, 2, 35}// 1123	1124	1125	
			, {1822, 8, 2, 35}, {1822, 10, 5, 15}, {1823, 11, 5, 25}// 1126	1127	1128	
			, {105, 0, -6, 84}, {1822, 3, 15, 5}, {1822, -3, 15, 5}// 1129	1131	1132	
			, {1822, 0, 15, 5}, {1822, 10, 10, 5}, {1822, 11, 13, 5}// 1133	1135	1139	
			, {1822, 10, 10, 13}, {1822, 10, 10, 10}, {1869, 11, 10, 5}// 1140	1141	1142	
			, {1822, 8, 12, 5}, {1822, 6, 14, 5}, {2, -2, 15, 5}// 1143	1144	1146	
			, {3, -2, 14, 5}, {1868, 14, 6, 5}, {1822, 16, 3, 5}// 1147	1148	1149	
			, {1867, 12, 6, 20}, {1822, 14, 5, 14}, {99, 12, -6, 45}// 1150	1151	1152	
			, {1822, 13, 1, 40}, {1822, 14, 6, 20}, {1822, 12, 6, 10}// 1153	1154	1155	
			, {1953, 12, 2, 35}, {1846, 13, 8, 10}, {1823, 12, 9, 10}// 1156	1157	1158	
			, {1822, 14, 5, 10}, {1868, 13, 7, 10}, {1822, 12, -2, 40}// 1159	1160	1161	
			, {1822, 13, 4, 26}, {1822, 12, 1, 40}, {1822, 12, 1, 35}// 1162	1163	1164	
			, {1822, 14, 5, 5}, {1822, 12, 0, 40}, {1867, 12, 8, 15}// 1165	1168	1169	
			, {1822, 17, 7, 5}, {1822, 12, 3, 10}, {1822, 12, 6, 5}// 1171	1172	1173	
			, {1822, 13, 5, 23}, {1822, 12, 2, 5}, {1822, 13, 7, 5}// 1175	1177	1178	
			, {1822, 12, 7, 5}, {1822, 12, 3, 5}, {1822, 12, 4, 5}// 1179	1180	1181	
			, {1822, 12, 8, 10}, {1822, 12, 5, 5}, {1822, 12, 8, 5}// 1182	1183	1184	
			, {1822, 12, -5, 40}, {1822, 12, 1, 10}, {1846, 14, 8, 5}// 1185	1186	1187	
			, {1822, 12, -4, 40}, {1846, 14, 7, 5}, {1822, 13, 8, 5}// 1188	1189	1190	
			, {2016, 12, 5, 20}, {1822, 12, 2, 20}, {1822, 15, 5, 5}// 1191	1194	1195	
			, {1822, 12, 9, 5}, {1822, 12, 5, 10}, {1822, 12, 7, 10}// 1196	1197	1198	
			, {1822, 12, 1, 5}, {1822, 12, 4, 10}, {1871, 13, 9, 10}// 1199	1202	1203	
			, {1822, 12, -3, 40}, {1846, 12, 7, 15}, {1822, 12, 6, 15}// 1204	1205	1206	
			, {100, 12, -1, 45}, {1822, 12, 1, 20}, {1822, 13, 2, 35}// 1207	1208	1209	
			, {1822, 12, -1, 40}, {1822, 12, 2, 10}, {1846, 14, 9, 5}// 1210	1211	1212	
			, {1822, 13, 9, 5}, {1822, 12, 3, 35}, {1822, 13, 6, 23}// 1213	1214	1215	
			, {1867, 12, 4, 23}, {1822, 12, 2, 15}, {1822, 13, 3, 35}// 1216	1217	1219	
			, {100, 12, 0, 45}, {100, 12, -5, 45}, {100, 12, -3, 45}// 1220	1221	1222	
			, {100, 12, -4, 45}, {100, 12, -2, 45}, {1822, 12, 1, 15}// 1223	1224	1225	
			, {1823, 13, 10, 5}, {1867, 14, 10, 5}, {1823, 12, 10, 5}// 1226	1227	1228	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new DespiseRespiteAddonDeed();
			}
		}

		[ Constructable ]
		public DespiseRespiteAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 3827, -11, -12, 72, 0, -1, "Bank Note", 1);// 3
			AddComplexComponent( (BaseAddon) this, 7955, -11, -13, 65, 0, -1, "Spawner", 1);// 59
			AddComplexComponent( (BaseAddon) this, 7964, -14, -8, 70, 0, -1, "Spawner", 1);// 71
			AddComplexComponent( (BaseAddon) this, 3649, -11, -8, 63, 1161, -1, "Trash Chest: Instantly deletes!", 1);// 186
			AddComplexComponent( (BaseAddon) this, 7964, -12, -8, 70, 0, -1, "Spawner", 1);// 212
			AddComplexComponent( (BaseAddon) this, 2852, -5, -9, 84, 0, 0, "", 1);// 372
			AddComplexComponent( (BaseAddon) this, 2852, -10, -9, 84, 0, 0, "", 1);// 375
			AddComplexComponent( (BaseAddon) this, 3633, -11, -5, 65, 0, 1, "", 1);// 422
			AddComplexComponent( (BaseAddon) this, 10659, -6, -5, 63, 0, 0, "", 1);// 482
			AddComplexComponent( (BaseAddon) this, 6587, -5, -5, 70, 0, 0, "", 1);// 489
			AddComplexComponent( (BaseAddon) this, 10659, -6, -1, 64, 0, 0, "", 1);// 499
			AddComplexComponent( (BaseAddon) this, 6587, -5, -1, 70, 0, 0, "", 1);// 615
			AddComplexComponent( (BaseAddon) this, 3633, -10, -5, 84, 0, 1, "", 1);// 649
			AddComplexComponent( (BaseAddon) this, 6587, -7, 10, 12, 0, 0, "", 1);// 655
			AddComplexComponent( (BaseAddon) this, 6587, -5, 13, 12, 0, 0, "", 1);// 656
			AddComplexComponent( (BaseAddon) this, 7964, -16, 13, 0, 0, -1, "Deadly Candy Apple", 1);// 658
			AddComplexComponent( (BaseAddon) this, 6587, 9, 7, 30, 0, 0, "", 1);// 850
			AddComplexComponent( (BaseAddon) this, 6587, -3, -5, 60, 0, 0, "", 1);// 873
			AddComplexComponent( (BaseAddon) this, 6570, 4, 2, 45, 0, 0, "", 1);// 875
			AddComplexComponent( (BaseAddon) this, 6587, -2, -1, 55, 0, 0, "", 1);// 891
			AddComplexComponent( (BaseAddon) this, 6587, -4, -5, 65, 0, 0, "", 1);// 907
			AddComplexComponent( (BaseAddon) this, 6587, -3, -1, 60, 0, 0, "", 1);// 914
			AddComplexComponent( (BaseAddon) this, 6570, 11, 1, 45, 0, 0, "", 1);// 923
			AddComplexComponent( (BaseAddon) this, 6587, 9, 8, 25, 0, 0, "", 1);// 950
			AddComplexComponent( (BaseAddon) this, 6570, 11, -2, 45, 0, 0, "", 1);// 958
			AddComplexComponent( (BaseAddon) this, 6587, 10, 9, 25, 0, 0, "", 1);// 971
			AddComplexComponent( (BaseAddon) this, 6587, 7, 4, 45, 0, 0, "", 1);// 995
			AddComplexComponent( (BaseAddon) this, 6587, 9, 6, 35, 0, 0, "", 1);// 996
			AddComplexComponent( (BaseAddon) this, 6570, 1, 2, 45, 0, 0, "", 1);// 1011
			AddComplexComponent( (BaseAddon) this, 6570, 8, -5, 45, 0, 0, "", 1);// 1018
			AddComplexComponent( (BaseAddon) this, 6570, 1, -1, 45, 0, 0, "", 1);// 1020
			AddComplexComponent( (BaseAddon) this, 6587, 9, 9, 22, 0, 0, "", 1);// 1021
			AddComplexComponent( (BaseAddon) this, 6587, 8, 5, 40, 0, 0, "", 1);// 1023
			AddComplexComponent( (BaseAddon) this, 6587, -4, -1, 65, 0, 0, "", 1);// 1081
			AddComplexComponent( (BaseAddon) this, 6587, -2, -5, 55, 0, 0, "", 1);// 1085
			AddComplexComponent( (BaseAddon) this, 6570, 11, -5, 45, 0, 0, "", 1);// 1095
			AddComplexComponent( (BaseAddon) this, 6570, 5, -5, 45, 0, 0, "", 1);// 1096
			AddComplexComponent( (BaseAddon) this, 6587, 5, 4, 50, 0, 0, "", 1);// 1114
			AddComplexComponent( (BaseAddon) this, 6570, 2, -5, 45, 0, 0, "", 1);// 1115
			AddComplexComponent( (BaseAddon) this, 6587, 0, 15, 12, 0, 0, "", 1);// 1130
			AddComplexComponent( (BaseAddon) this, 6587, 3, 15, 12, 0, 0, "", 1);// 1134
			AddComplexComponent( (BaseAddon) this, 6587, -3, 15, 12, 0, 0, "", 1);// 1136
			AddComplexComponent( (BaseAddon) this, 6587, 6, 14, 12, 0, 0, "", 1);// 1137
			AddComplexComponent( (BaseAddon) this, 6587, 8, 12, 12, 0, 0, "", 1);// 1138
			AddComplexComponent( (BaseAddon) this, 6587, 10, 10, 20, 0, 0, "", 1);// 1145
			AddComplexComponent( (BaseAddon) this, 6587, 13, 2, 42, 0, 0, "", 1);// 1166
			AddComplexComponent( (BaseAddon) this, 6587, 15, 5, 12, 0, 0, "", 1);// 1167
			AddComplexComponent( (BaseAddon) this, 6587, 13, 1, 49, 0, 0, "", 1);// 1170
			AddComplexComponent( (BaseAddon) this, 6587, 13, 6, 30, 0, 0, "", 1);// 1174
			AddComplexComponent( (BaseAddon) this, 6587, 13, 3, 42, 0, 0, "", 1);// 1176
			AddComplexComponent( (BaseAddon) this, 6587, 14, 6, 27, 0, 0, "", 1);// 1192
			AddComplexComponent( (BaseAddon) this, 6587, 13, 4, 33, 0, 0, "", 1);// 1193
			AddComplexComponent( (BaseAddon) this, 6587, 16, 3, 12, 0, 0, "", 1);// 1200
			AddComplexComponent( (BaseAddon) this, 6587, 14, 5, 21, 0, 0, "", 1);// 1201
			AddComplexComponent( (BaseAddon) this, 6587, 13, 5, 30, 0, 0, "", 1);// 1218

		}

		public DespiseRespiteAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class DespiseRespiteAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new DespiseRespiteAddon();
			}
		}

		[Constructable]
		public DespiseRespiteAddonDeed()
		{
			Name = "DespiseRespite";
		}

		public DespiseRespiteAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}