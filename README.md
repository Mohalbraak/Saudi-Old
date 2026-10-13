# مواقع ومعلومات عن أماكن أثرية في المملكة العربية السعودية

تطبيق واقع معزّز (AR) مبني بـ Unity و Vuforia Engine. يوجّه المستخدم الكاميرا نحو صورة
هدف (Image Target) لأحد المواقع الأثرية في المملكة، فيظهر المحتوى ثلاثي الأبعاد والمعلومات
الخاصة بالموقع.

An augmented-reality app built with Unity and Vuforia Engine: pointing the camera at an
image target of a Saudi heritage site brings up 3D content and information about it.

---

## المواقع المدعومة / Image targets

| الموقع | Target |
|---|---|
| قصر الملك عبدالعزيز | `KingAbdualaziz` |
| مدائن صالح | `MedanSalh` |
| عين زبيدة | `EianZubad` |
| جبل حوا (الحجاز) | `HawaHijaz` |

قواعد بيانات Vuforia: `Assets/StreamingAssets/Vuforia/Saudioldplaces` و `AOG-`.

---

## المتطلبات / Requirements

- **Unity 6000.3.25f1** (نفس الإصدار المستخدم في المشروع — `ProjectSettings/ProjectVersion.txt`)
- **Vuforia Engine 11.4.4** — غير مرفوع مع المستودع، انظر الخطوة 2 أدناه
- Universal Render Pipeline (URP) 17.3.0 — يُحمّل تلقائياً عبر Package Manager

---

## الإعداد بعد الاستنساخ / Setup after cloning

### 1. استنسخ المستودع

```bash
git clone https://github.com/Mohalbraak/Saudi-Old.git
```

### 2. أضف حزمة Vuforia Engine (مهم)

ملف `com.ptc.vuforia.engine-11.4.4.tgz` حجمه 138 ميجابايت، وهو أكبر من الحد الأقصى
لملفات GitHub (100 ميجابايت)، فلذلك **غير موجود في المستودع**. لتشغيل المشروع:

1. حمّل **Vuforia Engine 11.4.4** لـ Unity من <https://developer.vuforia.com/downloads/sdk>
2. ضع الملف `com.ptc.vuforia.engine-11.4.4.tgz` في مجلد:
   `مواقع و معلومات عن اماكن أثرية في المملكة العربية السعودية/Packages/`
3. افتح المشروع في Unity — سيتعرّف Package Manager على الحزمة تلقائياً من `manifest.json`

> الاعتماد معرّف في `Packages/manifest.json` كالتالي:
> `"com.ptc.vuforia.engine": "file:com.ptc.vuforia.engine-11.4.4.tgz"`

### 3. مفتاح ترخيص Vuforia

المشروع يحتاج مفتاح ترخيص Vuforia صالح. أنشئ مفتاحاً مجانياً من
<https://developer.vuforia.com/vui/develop/licenses> ثم أدخله في Unity من:

`Window → Vuforia Configuration → App License Key`

### 4. افتح المشهد

`Assets/Scenes/SampleScene.unity`

---

## هيكل المشروع / Project structure

```
مواقع و معلومات عن اماكن أثرية في المملكة العربية السعودية/
├── Assets/
│   ├── Scenes/SampleScene.unity          المشهد الرئيسي
│   ├── Editor/Vuforia/ImageTargetTextures/   صور الأهداف
│   ├── StreamingAssets/Vuforia/          قواعد بيانات الأهداف (.dat / .xml)
│   ├── Resources/VuforiaConfiguration.asset  إعدادات Vuforia
│   ├── Materials/ · textures/ · source/  الخامات والموديلات
│   ├── Details.cs · KingABDUA.cs         سكربتات عرض المعلومات
│   └── *.mp3                             المؤثرات الصوتية
├── Packages/manifest.json                اعتماديات المشروع
└── ProjectSettings/                      إعدادات Unity
```

---

## ملاحظات / Notes

- مجلدات `Library/`, `Temp/`, `Logs/`, `UserSettings/`, `obj/` و `.vs/` مستبعدة عبر
  `.gitignore` القياسي الخاص بـ Unity — سيعيد Unity توليدها عند أول فتح للمشروع.
- أول فتح للمشروع بعد الاستنساخ يأخذ وقتاً طويلاً لأن Unity يستورد كل الأصول من جديد.
