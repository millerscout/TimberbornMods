## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.CeilingBenchmarks.MathCeilingDouble()
;             int sum = 0;
;             ^^^^^^^^^^^^
;             var v = _values;
;             ^^^^^^^^^^^^^^^^
;             for (int i = 0; i < v.Length; i++)
;                  ^^^^^^^^^
;                 sum += (int)Math.Ceiling(v[i]); // float → double promotion
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return sum;
;             ^^^^^^^^^^^
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       add       rcx,10
M00_L00:
       vcvtss2sd xmm0,xmm0,dword ptr [rcx]
       vroundsd  xmm0,xmm0,xmm0,0A
       vcmpordsd xmm1,xmm0,xmm0
       vandpd    xmm1,xmm1,xmm0
       mov       r8d,7FFFFFFF
       vcvttsd2si r10d,xmm1
       vucomisd  xmm0,qword ptr [7FFBFC0F83C8]
       cmovb     r8d,r10d
       add       eax,r8d
       add       rcx,4
       dec       edx
       jne       short M00_L00
M00_L01:
       ret
; Total bytes of code 70
```

## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.CeilingBenchmarks.MathFCeilingFloat()
;             int sum = 0;
;             ^^^^^^^^^^^^
;             var v = _values;
;             ^^^^^^^^^^^^^^^^
;             for (int i = 0; i < v.Length; i++)
;                  ^^^^^^^^^
;                 sum += (int)MathF.Ceiling(v[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return sum;
;             ^^^^^^^^^^^
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       add       rcx,10
M00_L00:
       vroundss  xmm0,xmm0,dword ptr [rcx],0A
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r8d,7FFFFFFF
       vcvttss2si r10d,xmm1
       vucomiss  xmm0,dword ptr [7FFBFC1183C8]
       cmovb     r8d,r10d
       add       eax,r8d
       add       rcx,4
       dec       edx
       jne       short M00_L00
M00_L01:
       ret
; Total bytes of code 66
```

## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.CeilingBenchmarks.FastCeilPositive()
;             int sum = 0;
;             ^^^^^^^^^^^^
;             var v = _values;
;             ^^^^^^^^^^^^^^^^
;             for (int i = 0; i < v.Length; i++)
;                  ^^^^^^^^^
;                 sum += -(int)(-v[i]);
;                 ^^^^^^^^^^^^^^^^^^^^^
;             return sum;
;             ^^^^^^^^^^^
       xor       eax,eax
       mov       rcx,[rcx+8]
       mov       edx,[rcx+8]
       test      edx,edx
       jle       short M00_L01
       add       rcx,10
M00_L00:
       vmovss    xmm0,dword ptr [rcx]
       vxorps    xmm0,xmm0,[7FFBFC138430]
       vcmpordss xmm1,xmm0,xmm0
       vandps    xmm1,xmm1,xmm0
       mov       r8d,7FFFFFFF
       vcvttss2si r10d,xmm1
       vucomiss  xmm0,dword ptr [7FFBFC138440]
       cmovb     r8d,r10d
       sub       eax,r8d
       add       rcx,4
       dec       edx
       jne       short M00_L00
M00_L01:
       ret
; Total bytes of code 72
```

