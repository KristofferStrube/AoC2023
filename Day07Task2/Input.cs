﻿namespace Day07Task2;

public class Input
{
    public const string Literal =
"""
7227Q 52
67Q64 732
33Q33 573
58ATQ 939
93K53 840
55AJ8 496
6ATAT 863
26J77 1
TTQAT 381
2J2J2 322
342Q2 409
3444Q 864
77J67 31
772QJ 796
5388J 956
7JJ7J 88
5Q555 626
77AK8 588
J2222 661
36T93 934
5Q365 343
K3K3K 283
5959A 537
44477 560
6AA5K 208
5J445 262
28228 61
646A6 503
KK4Q8 471
A426T 500
AQ9JA 643
J784T 348
22J48 6
A5AJ5 220
62235 545
84JJJ 206
48464 669
44844 637
Q8537 969
95663 751
JTQK7 305
33TTT 335
4T925 32
9777Q 738
2QQ66 971
TQQ9T 657
69437 176
2555J 849
55AAA 26
94TT4 531
89T66 55
387J8 663
KKKKJ 198
K4KK4 870
622J2 330
6283A 337
JQQQ2 349
666AA 706
9794J 966
99A9T 771
53J53 477
7JT3J 829
KK524 765
Q4QQ4 486
J7367 519
KK4TJ 937
Q4983 168
74A77 997
Q2244 464
242J4 625
J2839 326
T927T 773
2Q992 875
77722 467
8K645 959
AJTJ3 650
64Q35 98
QQTQ4 973
24492 438
T8AK7 983
K439T 924
7AJ7J 426
T88T5 801
9J939 267
7K557 458
T9KQ3 231
34444 720
44TTT 781
AA3A9 177
78878 479
4K474 932
3TT65 634
98898 113
26286 702
37736 673
9Q9K3 103
9TT92 755
8AAJ8 845
55A55 356
K2222 184
7777Q 950
64392 649
36653 891
22AA2 201
55943 367
AQA2Q 178
4T693 806
385J5 429
246Q6 930
32J2Q 428
59Q83 128
8684Q 828
482Q9 668
243QA 250
JQTQQ 656
45645 354
7J648 534
44633 638
A3283 284
38262 830
QAT67 976
7662Q 241
266T2 355
3AA67 958
JTTTT 51
A3T22 739
6A45J 978
969JJ 965
69K98 413
8Q33Q 239
886QQ 135
Q44JK 525
TT6TT 64
77773 451
8AKK8 172
QTQ2T 872
QQTQ7 642
44666 387
J4Q74 225
4J968 542
Q6939 831
2773T 420
55565 313
76666 9
5J4J4 212
TTJQJ 601
358K2 725
JQ78Q 597
3K3TK 685
QKQQQ 261
5Q59Q 762
Q77QQ 756
KK2J2 728
TKKK5 879
9KQ9K 785
Q83JK 96
39998 256
TTJ3T 852
66866 192
2567T 211
76969 20
KAKKK 735
9Q5QQ 808
JQ87K 67
J8887 320
J9763 36
A6464 75
K5AA5 996
TTJ7T 890
7KKK7 450
72752 817
K2J32 915
T25J7 72
QQ6Q6 53
27T7J 577
98J89 236
23525 404
44244 34
2K8J7 509
AK427 108
7K6KA 466
374J7 553
533K3 78
8J6K2 301
J7577 995
T88T8 903
626K6 265
2A96A 462
T4987 279
JJTKJ 69
77767 641
2Q232 210
444JJ 133
7Q7JQ 508
5555K 888
46462 874
KQKKK 474
96737 10
7AT28 234
2QJTA 229
9T8T8 111
373KJ 263
95599 605
A7Q66 719
82555 291
9KK8T 810
Q87KK 102
TT2TT 792
888T8 772
9J767 972
9496J 774
4KJ44 511
KA5KK 790
4J222 944
2325A 961
AQJ5A 118
J555J 698
9899J 862
5496K 590
A97J4 287
77JA3 695
959Q9 79
29927 516
K88A3 400
9997J 541
58A6J 452
2QTKA 447
777KK 154
47J2K 907
QJ5A4 592
JAA8J 730
K5J55 982
3QQQ3 85
725QK 140
5KK55 678
A5AQ9 871
3J639 149
99899 623
7AAA7 152
7777J 401
75492 895
TQ549 900
2A7TT 991
2J36J 559
95K83 433
44TTA 778
98J9Q 378
55TQ9 581
3AK7T 50
94399 869
Q43JA 109
34KKJ 569
88499 27
22525 737
7T9K6 523
337J9 141
99959 339
JK9K9 444
5T55T 680
339T9 562
JJKKK 366
KJTJK 814
9KJ55 299
5969J 672
92273 416
6TQ68 107
T36K5 938
K26K6 884
5625J 93
44393 196
55558 100
96666 521
4938T 813
2QQ8Q 244
8887T 885
KT92Q 189
6K766 60
67676 481
QQ524 427
58598 520
4J454 777
6Q82Q 303
6Q6J3 435
83993 670
32232 873
T488T 795
622J6 893
53323 914
J77J7 205
55954 385
KJK48 251
96AQK 861
QJT45 653
K3826 835
44447 546
4T877 793
88333 701
QQQJ8 566
36663 799
66Q5Q 41
A44Q9 43
47KKK 783
23J22 3
67JQQ 289
K43J7 484
QJQQQ 89
32T65 709
4646T 515
T3A29 535
75665 952
KQQ2T 837
AJTT4 578
QK4Q4 288
6J6JJ 312
28887 138
33TK4 599
77J2J 946
566J5 63
333A5 457
A2A66 575
6296T 611
3TQ46 373
J888J 726
KKJ4K 948
J5T4A 455
4T74T 962
473A8 431
ATATA 514
4Q385 269
K65K6 383
398K4 715
65JT7 630
8A6J9 419
QA5JQ 585
Q45KA 754
AAA66 173
4949Q 733
K9972 22
KTKKK 422
5JQ22 502
K787K 302
TT8TJ 527
265KA 363
KK7KK 745
6263K 498
65J2K 565
26322 104
44Q74 731
23383 276
KQ948 687
9552J 504
75JA6 95
3JJ33 994
28824 716
2A8JK 13
22868 38
88388 987
A955Q 963
54T86 547
55547 671
5TK7Q 417
4Q35K 842
33353 492
96A85 878
Q6QAQ 867
K55KJ 822
97QK2 398
K6229 162
4TT84 518
Q67AJ 628
2TT22 776
2QJ24 766
A8TT8 418
A74Q2 704
77T7T 399
774JT 789
6A845 371
8JQ5Q 970
55645 757
68788 896
5J2J7 350
K88J6 853
3AAA3 160
3J777 125
3666K 247
5QA98 887
QJ272 106
45555 767
3T3T3 441
4448T 260
A9A9A 550
76JA6 591
6T4T8 984
KT7JK 748
727T2 253
8Q77A 364
Q8448 507
T3JJ9 707
8Q88Q 555
A84AA 370
7QQ26 804
35377 616
TK3KK 87
T764T 688
AT9A8 45
A6AA5 328
57T63 315
62622 627
66366 788
JKQKQ 980
6T5AQ 841
58585 693
3KA73 411
44884 949
AA958 615
4Q26A 886
57AJ7 564
84J48 342
633TJ 295
29222 606
Q222Q 453
JAQAA 818
T6TTJ 290
Q3KAJ 563
666TT 844
K28QQ 286
KK46K 811
T2222 714
8A883 463
JJ73J 83
AJK26 538
72A34 266
TKK9Q 877
333AA 382
8T28T 470
888A5 910
5A365 664
88JKK 310
55235 551
K2KKK 308
AA688 809
62T6Q 57
AA2A4 336
9999K 268
44J8T 227
67877 461
K33QK 21
Q44JQ 423
TK787 71
A78A6 749
QJAQQ 331
J2A52 935
965TT 54
598J5 729
K8KKJ 857
K5J6K 340
QJQ22 47
685QA 230
9999J 617
A9339 321
953T4 920
33373 859
8JJ8T 922
42K39 116
QQ432 449
K24K2 345
4A442 802
3JKK3 758
6JTTQ 185
5K9J7 124
7A779 325
68868 998
JQ355 224
TK456 568
93793 150
449J9 33
57777 248
666KK 750
T333J 703
466AA 613
5JJ8Q 226
AQTQT 779
33355 23
33TQ3 974
8J588 992
KJKKQ 832
34J97 694
K9993 70
QQQ9Q 228
4K9AQ 148
7KKJ9 379
99944 571
TT3Q8 297
T2QA9 921
JJ55T 561
J6KAQ 607
4735Q 259
3J547 223
64464 574
77J94 919
626Q6 923
J3832 631
96QK3 391
A4J4A 421
J77KK 723
K8354 285
JATQ9 273
28732 209
72779 666
4J255 243
777K7 202
JJQ5J 645
82A47 612
888T4 97
22K2K 736
T35Q8 752
94238 700
5K242 324
5QJ5A 927
4T6KA 892
74J8A 960
4J4JK 791
A76QQ 159
988A8 143
86J32 39
7QK32 512
7TTTT 483
KK27K 252
8A366 529
8333J 182
52QQ5 164
95926 219
AK33A 977
A368K 988
QQA5Q 858
5999J 848
KK9JK 110
6Q2Q2 570
AAKK7 600
555Q3 277
2A2A6 614
38853 2
JTA82 608
8J668 636
J999K 30
QJ35T 505
AQ7AA 121
777KJ 389
J6282 465
8K2T3 332
43Q82 760
66T6K 734
7A77A 454
A98AA 99
QQ7QQ 362
99J9J 129
444TJ 74
A7263 16
74749 699
2K2KK 137
8K6JQ 146
6TJ58 902
72222 123
9A97A 415
37TT6 380
88882 651
66555 311
55J55 270
77A72 430
33Q5Q 193
TTQ44 369
3TT8T 278
428T3 132
AK897 214
7QQQJ 697
9AK62 157
96466 487
J522J 238
9J7A9 394
QQK77 584
Q72T4 24
26662 169
9KK32 908
45QJ6 576
45QKJ 690
KK248 696
AAAA4 652
2T2QQ 681
9992J 216
47777 929
KJT5J 73
5TA64 593
55AA5 780
7QT35 58
8JTJ6 648
K4K54 712
44Q49 539
KT427 665
TJ3T3 191
T7758 945
A9347 609
942J2 386
QQ9J9 81
J7445 957
7A54J 889
QK44K 207
7KJ99 683
7888Q 925
44J44 583
365K8 794
88983 675
2T2QJ 375
28K2J 222
84A8T 372
72796 264
3KKAK 708
59559 722
7JK35 5
J8Q88 913
QA543 942
86A68 866
T4A4A 746
QAQQQ 640
J8T8T 408
77JT6 679
J5779 323
86AA3 803
TAAA3 376
5J6K5 217
78253 787
TTTK3 357
Q8599 368
QTTTT 199
77K3K 309
TKJKK 644
7Q554 307
KKQKQ 445
77866 403
44355 272
J6969 968
985A3 667
JJQQQ 333
5J9JT 281
6T4A4 156
KA9J2 999
22329 405
3QK93 692
2T2TT 827
22999 240
TK7JJ 101
7287A 567
J4J24 360
AAJ53 424
JAA45 769
77282 981
7777T 548
43533 572
93932 180
7AAAA 926
8K888 782
4747J 495
684QJ 40
73495 855
2552J 293
7QKT2 497
AA4A6 163
2T8TT 897
7J746 407
3J234 807
Q3QQQ 358
AJAJA 66
8K5Q5 115
K9TTJ 485
33Q7Q 186
T7797 604
69989 443
J666T 11
J2233 532
94969 410
889Q8 17
K97A6 298
73T3J 334
663J6 821
54QQT 770
4AAA4 432
4334A 967
JJJJJ 647
JK2TT 904
2774A 280
K8KJA 834
AJ38A 763
3KKKJ 836
69693 1000
48J47 955
7KA7K 905
33244 691
5A435 557
87KA8 472
J2484 341
K35K5 815
K8Q2A 29
KK3Q4 390
7J77A 300
84T5T 589
7893T 964
22AAA 235
QKK6Q 142
T6A48 122
T22T9 167
KA53Q 686
68J5K 947
64625 727
3T5T3 120
2992J 846
A3K8J 145
QK99J 838
4A4AQ 91
KKK8K 491
AAA28 480
42772 304
T222A 204
K6Q37 558
Q5K6A 352
8QJQ8 682
832J8 147
Q388T 170
9555J 12
7KTT9 658
KAAKK 911
TKTTT 174
44TJ2 993
6KK6K 136
5A5TA 494
AAJ22 15
633Q3 740
QQQ4Q 933
4A4Q2 237
33555 402
Q9A23 549
3Q343 936
9Q799 14
3KKKQ 618
JKK54 876
96996 25
2T374 439
4QJAQ 374
JQ64K 718
464Q6 187
J9252 271
88Q38 396
K4J55 912
5JT73 434
KK6J4 195
A8AAA 388
79793 353
877J7 943
J4484 662
A434J 812
TTQJ7 493
63333 711
22262 540
474QQ 975
Q22K2 393
K5KK2 621
QQ62T 524
J6666 188
AAQAA 883
65666 126
778K8 65
8A3T9 90
AA392 392
T593T 151
QQ2KK 654
765KA 953
Q5QQ7 475
4KTK4 677
66243 580
895TJ 175
QT345 436
3332T 865
2T5J9 414
24J9K 181
5557A 249
J3J5J 513
75555 741
659T2 689
TQ5TJ 530
7T48A 194
23332 629
KJKK6 490
43J33 344
K55KK 624
A8JAA 622
68J89 880
KJQT9 44
98989 526
Q3QT4 602
764QQ 134
772Q7 127
6K6T5 274
383Q8 139
JK677 764
TTT4T 56
76K82 153
JAAAA 717
33JJ5 684
8TTKT 985
8T74T 928
88J88 916
74938 660
3TK74 338
T98K5 397
99A69 488
24A6K 197
43A42 144
TT9J9 579
J837Q 552
44464 820
82A5A 329
ATAAJ 183
83899 190
88TQT 292
69482 130
36J36 4
458T7 860
4Q29Q 473
KKK4K 676
4K756 800
8J8JJ 898
TTTT9 881
88J28 203
42422 744
QQQKK 112
4J2Q7 327
57922 582
44A44 37
35559 705
T8TQQ 246
JQ29K 536
9A999 825
62TT2 499
K3567 218
72J22 215
87487 377
5J655 489
26769 816
577A7 851
44T86 131
7QQ72 460
28QJ3 954
243K7 979
24J97 724
4QKT3 742
A88AA 619
363AA 610
T24TJ 117
92AJ6 587
J666J 596
Q7J36 850
Q3968 901
8J7JK 798
5J9T3 84
29Q22 674
5588J 598
7747T 833
735A6 384
44944 68
44J26 365
52555 77
Q4TT3 476
K88TK 440
6JJTT 632
KTA54 759
KKT5T 254
A85A5 80
96J6J 469
9KKKK 556
37733 18
KJJ66 282
2Q882 989
JJ8JJ 868
TTJTJ 603
AKAAA 710
J6TT6 49
Q7JT7 448
8T728 319
86J55 161
8K5KK 805
KKATT 459
T929J 743
2238J 86
99929 119
82Q5T 314
22297 7
Q58QQ 437
8A8Q5 46
87J2Q 761
T2A35 823
9TQQQ 395
2KT69 232
5T566 506
J33QQ 179
2T652 275
KT228 909
9T229 82
TA696 986
Q3585 317
AQKAA 42
J9JJ9 713
QQ448 951
T664T 786
J2J5J 824
67677 635
QQQQT 899
333J3 442
Q2QQ2 753
8K79T 917
J82A2 839
T5TTT 155
4K4Q8 721
A7JAJ 306
4Q44Q 940
2J6KJ 854
77979 59
57575 296
QK66Q 166
Q5QQK 257
8Q5J2 528
TKJ27 882
TT7T5 843
2227A 94
45784 594
AQK97 468
98TTT 446
2886T 346
JAA66 826
44333 478
A33J3 114
Q82T6 620
J833Q 165
4T98J 105
44499 775
Q5Q5Q 245
37477 931
28QKT 655
3K388 213
J3838 19
83444 48
7TTAT 316
87777 768
KJTK5 639
QQQ27 200
22299 797
99K9A 412
44454 586
J689T 894
86888 294
TATTA 456
24452 517
54Q42 62
T97TT 646
QJAAJ 533
23K8Q 359
AAJ5A 941
59985 747
6TT55 510
Q6892 784
Q66Q7 595
A2223 28
6989J 221
944A6 659
7K524 171
49498 544
55Q29 8
8A787 351
A7Q7Q 242
92444 406
558J2 255
7JT77 258
493K9 233
7A333 501
9TQ9Q 554
J92KT 76
9TJ67 522
43443 906
9TTT9 92
66266 918
AKKAA 543
7ATJJ 361
K86J6 482
22422 633
AAATQ 318
64637 856
72777 347
6QQ66 158
37377 990
A8624 35
27276 847
22954 425
TK4JT 819
""";
}
