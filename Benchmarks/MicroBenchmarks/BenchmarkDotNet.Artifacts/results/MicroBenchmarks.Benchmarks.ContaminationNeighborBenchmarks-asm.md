## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.ContaminationNeighborBenchmarks.NoEarlyExit()
;             var candidates = _candidates;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var heightDiffs = _heightDiffs;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             float currentContamination = 0f;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             for (int i = 0; i < N; i++)
;                  ^^^^^^^^^
;                 int diff = heightDiffs[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 float result = candidates[i] - verticalPenalty - Cost;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 if (result > currentContamination)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     currentContamination = result;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return currentContamination;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       rcx,[rcx+10]
       vxorps    xmm0,xmm0,xmm0
       xor       edx,edx
       test      rcx,rcx
       je        short M00_L04
       nop       dword ptr [rax]
       test      rax,rax
       je        short M00_L04
       mov       r8d,[rcx+8]
       cmp       r8d,60000
       jl        short M00_L04
       cmp       dword ptr [rax+8],60000
       jl        short M00_L04
       vmovss    xmm1,dword ptr [7FFBFC128848]
       vmovss    xmm2,dword ptr [7FFBFC12884C]
       mov       r8d,10
       mov       edx,60000
       jmp       short M00_L03
M00_L00:
       add       rsp,28
       ret
M00_L01:
       vmovaps   xmm0,xmm3
M00_L02:
       add       r8,4
       dec       edx
       je        short M00_L00
M00_L03:
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2ss xmm3,xmm3,dword ptr [rcx+r8]
       vmulss    xmm3,xmm3,xmm1
       vmovss    xmm4,dword ptr [rax+r8]
       vsubss    xmm3,xmm4,xmm3
       vsubss    xmm3,xmm3,xmm2
       vucomiss  xmm3,xmm0
       jbe       short M00_L02
       jmp       short M00_L01
M00_L04:
       mov       r8d,[rcx+8]
       vmovss    xmm1,dword ptr [7FFBFC128848]
       vmovss    xmm2,dword ptr [7FFBFC12884C]
       jmp       short M00_L06
       xchg      ax,ax
M00_L05:
       inc       edx
       cmp       edx,60000
       jge       short M00_L00
M00_L06:
       cmp       edx,r8d
       jae       short M00_L07
       mov       r10d,edx
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2ss xmm3,xmm3,dword ptr [rcx+r10*4+10]
       vmulss    xmm3,xmm3,xmm1
       cmp       edx,[rax+8]
       jae       short M00_L07
       vmovss    xmm4,dword ptr [rax+r10*4+10]
       vsubss    xmm3,xmm4,xmm3
       vsubss    xmm3,xmm3,xmm2
       vucomiss  xmm3,xmm0
       jbe       short M00_L05
       vmovaps   xmm0,xmm3
       jmp       short M00_L05
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
```

## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.ContaminationNeighborBenchmarks.WithEarlyExit()
;             var candidates = _candidates;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var heightDiffs = _heightDiffs;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             float currentContamination = 0f;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             for (int i = 0; i < N; i++)
;                  ^^^^^^^^^
;                 if (candidates[i] <= currentContamination + Cost)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 int diff = heightDiffs[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 float result = candidates[i] - verticalPenalty - Cost;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 if (result > currentContamination)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     currentContamination = result;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return currentContamination;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       rcx,[rcx+10]
       vxorps    xmm0,xmm0,xmm0
       xor       edx,edx
       test      rax,rax
       je        short M00_L02
       nop       dword ptr [rax]
       test      rcx,rcx
       je        short M00_L02
       nop       dword ptr [rax]
       mov       r8d,[rax+8]
       cmp       r8d,60000
       jl        short M00_L02
       cmp       dword ptr [rcx+8],60000
       jl        short M00_L02
       vmovss    xmm1,dword ptr [7FFBFC1088F8]
       mov       r8d,10
       mov       edx,60000
       jmp       short M00_L01
       nop
M00_L00:
       add       r8,4
       dec       edx
       je        near ptr M00_L05
M00_L01:
       vaddss    xmm2,xmm0,xmm1
       vucomiss  xmm2,dword ptr [rax+r8]
       jae       short M00_L00
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2ss xmm2,xmm2,dword ptr [rcx+r8]
       vmulss    xmm2,xmm2,dword ptr [7FFBFC1088FC]
       vmovss    xmm3,dword ptr [rax+r8]
       vsubss    xmm2,xmm3,xmm2
       vsubss    xmm2,xmm2,xmm1
       vucomiss  xmm2,xmm0
       jbe       short M00_L00
       vmovaps   xmm0,xmm2
       jmp       short M00_L00
M00_L02:
       mov       r8d,[rax+8]
       vmovss    xmm1,dword ptr [7FFBFC1088F8]
       jmp       short M00_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L03:
       inc       edx
       cmp       edx,60000
       jge       short M00_L05
M00_L04:
       cmp       edx,r8d
       jae       short M00_L06
       mov       r10d,edx
       vaddss    xmm2,xmm0,xmm1
       vucomiss  xmm2,dword ptr [rax+r10*4+10]
       jae       short M00_L03
       cmp       edx,[rcx+8]
       jae       short M00_L06
       mov       r10d,edx
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2ss xmm2,xmm2,dword ptr [rcx+r10*4+10]
       vmulss    xmm2,xmm2,dword ptr [7FFBFC1088FC]
       mov       r10d,edx
       vmovss    xmm3,dword ptr [rax+r10*4+10]
       vsubss    xmm2,xmm3,xmm2
       vsubss    xmm2,xmm2,xmm1
       vucomiss  xmm2,xmm0
       jbe       short M00_L03
       vmovaps   xmm0,xmm2
       jmp       short M00_L03
M00_L05:
       add       rsp,28
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.ContaminationNeighborBenchmarks.NoEarlyExit()
;             var candidates = _candidates;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var heightDiffs = _heightDiffs;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             float currentContamination = 0f;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             for (int i = 0; i < N; i++)
;                  ^^^^^^^^^
;                 int diff = heightDiffs[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 float result = candidates[i] - verticalPenalty - Cost;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 if (result > currentContamination)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     currentContamination = result;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return currentContamination;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       rcx,[rcx+10]
       vxorps    xmm0,xmm0,xmm0
       xor       edx,edx
       test      rcx,rcx
       je        short M00_L04
       nop       dword ptr [rax]
       test      rax,rax
       je        short M00_L04
       mov       r8d,[rcx+8]
       cmp       r8d,60000
       jl        short M00_L04
       cmp       dword ptr [rax+8],60000
       jl        short M00_L04
       vmovss    xmm1,dword ptr [7FFBFC128848]
       vmovss    xmm2,dword ptr [7FFBFC12884C]
       mov       r8d,10
       mov       edx,60000
       jmp       short M00_L03
M00_L00:
       add       rsp,28
       ret
M00_L01:
       vmovaps   xmm0,xmm3
M00_L02:
       add       r8,4
       dec       edx
       je        short M00_L00
M00_L03:
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2ss xmm3,xmm3,dword ptr [rcx+r8]
       vmulss    xmm3,xmm3,xmm1
       vmovss    xmm4,dword ptr [rax+r8]
       vsubss    xmm3,xmm4,xmm3
       vsubss    xmm3,xmm3,xmm2
       vucomiss  xmm3,xmm0
       jbe       short M00_L02
       jmp       short M00_L01
M00_L04:
       mov       r8d,[rcx+8]
       vmovss    xmm1,dword ptr [7FFBFC128848]
       vmovss    xmm2,dword ptr [7FFBFC12884C]
       jmp       short M00_L06
       xchg      ax,ax
M00_L05:
       inc       edx
       cmp       edx,60000
       jge       short M00_L00
M00_L06:
       cmp       edx,r8d
       jae       short M00_L07
       mov       r10d,edx
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2ss xmm3,xmm3,dword ptr [rcx+r10*4+10]
       vmulss    xmm3,xmm3,xmm1
       cmp       edx,[rax+8]
       jae       short M00_L07
       vmovss    xmm4,dword ptr [rax+r10*4+10]
       vsubss    xmm3,xmm4,xmm3
       vsubss    xmm3,xmm3,xmm2
       vucomiss  xmm3,xmm0
       jbe       short M00_L05
       vmovaps   xmm0,xmm3
       jmp       short M00_L05
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
```

## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.ContaminationNeighborBenchmarks.WithEarlyExit()
;             var candidates = _candidates;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var heightDiffs = _heightDiffs;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             float currentContamination = 0f;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             for (int i = 0; i < N; i++)
;                  ^^^^^^^^^
;                 if (candidates[i] <= currentContamination + Cost)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 int diff = heightDiffs[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 float result = candidates[i] - verticalPenalty - Cost;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 if (result > currentContamination)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     currentContamination = result;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return currentContamination;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       rcx,[rcx+10]
       vxorps    xmm0,xmm0,xmm0
       xor       edx,edx
       test      rax,rax
       je        short M00_L02
       nop       dword ptr [rax]
       test      rcx,rcx
       je        short M00_L02
       nop       dword ptr [rax]
       mov       r8d,[rax+8]
       cmp       r8d,60000
       jl        short M00_L02
       cmp       dword ptr [rcx+8],60000
       jl        short M00_L02
       vmovss    xmm1,dword ptr [7FFBFC1088F8]
       mov       r8d,10
       mov       edx,60000
       jmp       short M00_L01
       nop
M00_L00:
       add       r8,4
       dec       edx
       je        near ptr M00_L05
M00_L01:
       vaddss    xmm2,xmm0,xmm1
       vucomiss  xmm2,dword ptr [rax+r8]
       jae       short M00_L00
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2ss xmm2,xmm2,dword ptr [rcx+r8]
       vmulss    xmm2,xmm2,dword ptr [7FFBFC1088FC]
       vmovss    xmm3,dword ptr [rax+r8]
       vsubss    xmm2,xmm3,xmm2
       vsubss    xmm2,xmm2,xmm1
       vucomiss  xmm2,xmm0
       jbe       short M00_L00
       vmovaps   xmm0,xmm2
       jmp       short M00_L00
M00_L02:
       mov       r8d,[rax+8]
       vmovss    xmm1,dword ptr [7FFBFC1088F8]
       jmp       short M00_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L03:
       inc       edx
       cmp       edx,60000
       jge       short M00_L05
M00_L04:
       cmp       edx,r8d
       jae       short M00_L06
       mov       r10d,edx
       vaddss    xmm2,xmm0,xmm1
       vucomiss  xmm2,dword ptr [rax+r10*4+10]
       jae       short M00_L03
       cmp       edx,[rcx+8]
       jae       short M00_L06
       mov       r10d,edx
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2ss xmm2,xmm2,dword ptr [rcx+r10*4+10]
       vmulss    xmm2,xmm2,dword ptr [7FFBFC1088FC]
       mov       r10d,edx
       vmovss    xmm3,dword ptr [rax+r10*4+10]
       vsubss    xmm2,xmm3,xmm2
       vsubss    xmm2,xmm2,xmm1
       vucomiss  xmm2,xmm0
       jbe       short M00_L03
       vmovaps   xmm0,xmm2
       jmp       short M00_L03
M00_L05:
       add       rsp,28
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.ContaminationNeighborBenchmarks.NoEarlyExit()
;             var candidates = _candidates;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var heightDiffs = _heightDiffs;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             float currentContamination = 0f;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             for (int i = 0; i < N; i++)
;                  ^^^^^^^^^
;                 int diff = heightDiffs[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 float result = candidates[i] - verticalPenalty - Cost;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 if (result > currentContamination)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     currentContamination = result;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return currentContamination;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       rcx,[rcx+10]
       vxorps    xmm0,xmm0,xmm0
       xor       edx,edx
       test      rcx,rcx
       je        short M00_L04
       nop       dword ptr [rax]
       test      rax,rax
       je        short M00_L04
       mov       r8d,[rcx+8]
       cmp       r8d,60000
       jl        short M00_L04
       cmp       dword ptr [rax+8],60000
       jl        short M00_L04
       vmovss    xmm1,dword ptr [7FFBFC128848]
       vmovss    xmm2,dword ptr [7FFBFC12884C]
       mov       r8d,10
       mov       edx,60000
       jmp       short M00_L03
M00_L00:
       add       rsp,28
       ret
M00_L01:
       vmovaps   xmm0,xmm3
M00_L02:
       add       r8,4
       dec       edx
       je        short M00_L00
M00_L03:
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2ss xmm3,xmm3,dword ptr [rcx+r8]
       vmulss    xmm3,xmm3,xmm1
       vmovss    xmm4,dword ptr [rax+r8]
       vsubss    xmm3,xmm4,xmm3
       vsubss    xmm3,xmm3,xmm2
       vucomiss  xmm3,xmm0
       jbe       short M00_L02
       jmp       short M00_L01
M00_L04:
       mov       r8d,[rcx+8]
       vmovss    xmm1,dword ptr [7FFBFC128848]
       vmovss    xmm2,dword ptr [7FFBFC12884C]
       jmp       short M00_L06
       xchg      ax,ax
M00_L05:
       inc       edx
       cmp       edx,60000
       jge       short M00_L00
M00_L06:
       cmp       edx,r8d
       jae       short M00_L07
       mov       r10d,edx
       vxorps    xmm3,xmm3,xmm3
       vcvtsi2ss xmm3,xmm3,dword ptr [rcx+r10*4+10]
       vmulss    xmm3,xmm3,xmm1
       cmp       edx,[rax+8]
       jae       short M00_L07
       vmovss    xmm4,dword ptr [rax+r10*4+10]
       vsubss    xmm3,xmm4,xmm3
       vsubss    xmm3,xmm3,xmm2
       vucomiss  xmm3,xmm0
       jbe       short M00_L05
       vmovaps   xmm0,xmm3
       jmp       short M00_L05
M00_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
```

## .NET 10.0.5 (10.0.526.15411), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
```assembly
; MicroBenchmarks.Benchmarks.ContaminationNeighborBenchmarks.WithEarlyExit()
;             var candidates = _candidates;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             var heightDiffs = _heightDiffs;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             float currentContamination = 0f;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             for (int i = 0; i < N; i++)
;                  ^^^^^^^^^
;                 if (candidates[i] <= currentContamination + Cost)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 int diff = heightDiffs[i];
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 float result = candidates[i] - verticalPenalty - Cost;
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 if (result > currentContamination)
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                     currentContamination = result;
;                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;             return currentContamination;
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       rcx,[rcx+10]
       vxorps    xmm0,xmm0,xmm0
       xor       edx,edx
       test      rax,rax
       je        short M00_L02
       nop       dword ptr [rax]
       test      rcx,rcx
       je        short M00_L02
       nop       dword ptr [rax]
       mov       r8d,[rax+8]
       cmp       r8d,60000
       jl        short M00_L02
       cmp       dword ptr [rcx+8],60000
       jl        short M00_L02
       vmovss    xmm1,dword ptr [7FFBFC1188F8]
       mov       r8d,10
       mov       edx,60000
       jmp       short M00_L01
       nop
M00_L00:
       add       r8,4
       dec       edx
       je        near ptr M00_L05
M00_L01:
       vaddss    xmm2,xmm0,xmm1
       vucomiss  xmm2,dword ptr [rax+r8]
       jae       short M00_L00
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2ss xmm2,xmm2,dword ptr [rcx+r8]
       vmulss    xmm2,xmm2,dword ptr [7FFBFC1188FC]
       vmovss    xmm3,dword ptr [rax+r8]
       vsubss    xmm2,xmm3,xmm2
       vsubss    xmm2,xmm2,xmm1
       vucomiss  xmm2,xmm0
       jbe       short M00_L00
       vmovaps   xmm0,xmm2
       jmp       short M00_L00
M00_L02:
       mov       r8d,[rax+8]
       vmovss    xmm1,dword ptr [7FFBFC1188F8]
       jmp       short M00_L04
       nop       dword ptr [rax]
       nop       dword ptr [rax]
M00_L03:
       inc       edx
       cmp       edx,60000
       jge       short M00_L05
M00_L04:
       cmp       edx,r8d
       jae       short M00_L06
       mov       r10d,edx
       vaddss    xmm2,xmm0,xmm1
       vucomiss  xmm2,dword ptr [rax+r10*4+10]
       jae       short M00_L03
       cmp       edx,[rcx+8]
       jae       short M00_L06
       mov       r10d,edx
       vxorps    xmm2,xmm2,xmm2
       vcvtsi2ss xmm2,xmm2,dword ptr [rcx+r10*4+10]
       vmulss    xmm2,xmm2,dword ptr [7FFBFC1188FC]
       mov       r10d,edx
       vmovss    xmm3,dword ptr [rax+r10*4+10]
       vsubss    xmm2,xmm3,xmm2
       vsubss    xmm2,xmm2,xmm1
       vucomiss  xmm2,xmm0
       jbe       short M00_L03
       vmovaps   xmm0,xmm2
       jmp       short M00_L03
M00_L05:
       add       rsp,28
       ret
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 275
```

