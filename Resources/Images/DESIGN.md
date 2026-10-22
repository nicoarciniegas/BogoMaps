---
name: Civic Mobility & Urban Safety
colors:
  surface: '#faf8ff'
  surface-dim: '#d2d9f4'
  surface-bright: '#faf8ff'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f2f3ff'
  surface-container: '#eaedff'
  surface-container-high: '#e2e7ff'
  surface-container-highest: '#dae2fd'
  on-surface: '#131b2e'
  on-surface-variant: '#434655'
  inverse-surface: '#283044'
  inverse-on-surface: '#eef0ff'
  outline: '#737686'
  outline-variant: '#c3c6d7'
  surface-tint: '#0053db'
  primary: '#004ac6'
  on-primary: '#ffffff'
  primary-container: '#2563eb'
  on-primary-container: '#eeefff'
  inverse-primary: '#b4c5ff'
  secondary: '#006c49'
  on-secondary: '#ffffff'
  secondary-container: '#6cf8bb'
  on-secondary-container: '#00714d'
  tertiary: '#784b00'
  on-tertiary: '#ffffff'
  tertiary-container: '#996100'
  on-tertiary-container: '#ffeedd'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#dbe1ff'
  primary-fixed-dim: '#b4c5ff'
  on-primary-fixed: '#00174b'
  on-primary-fixed-variant: '#003ea8'
  secondary-fixed: '#6ffbbe'
  secondary-fixed-dim: '#4edea3'
  on-secondary-fixed: '#002113'
  on-secondary-fixed-variant: '#005236'
  tertiary-fixed: '#ffddb8'
  tertiary-fixed-dim: '#ffb95f'
  on-tertiary-fixed: '#2a1700'
  on-tertiary-fixed-variant: '#653e00'
  background: '#faf8ff'
  on-background: '#131b2e'
  surface-variant: '#dae2fd'
typography:
  display-lg:
    fontFamily: Plus Jakarta Sans
    fontSize: 32px
    fontWeight: '800'
    lineHeight: 40px
  headline-lg:
    fontFamily: Plus Jakarta Sans
    fontSize: 24px
    fontWeight: '700'
    lineHeight: 32px
  headline-md:
    fontFamily: Plus Jakarta Sans
    fontSize: 20px
    fontWeight: '700'
    lineHeight: 28px
  headline-sm:
    fontFamily: Plus Jakarta Sans
    fontSize: 18px
    fontWeight: '600'
    lineHeight: 24px
  body-lg:
    fontFamily: Plus Jakarta Sans
    fontSize: 16px
    fontWeight: '500'
    lineHeight: 24px
  body-md:
    fontFamily: Plus Jakarta Sans
    fontSize: 14px
    fontWeight: '400'
    lineHeight: 20px
  body-sm:
    fontFamily: Plus Jakarta Sans
    fontSize: 13px
    fontWeight: '400'
    lineHeight: 18px
  label-lg:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '600'
    lineHeight: 18px
  label-md:
    fontFamily: Inter
    fontSize: 12px
    fontWeight: '600'
    lineHeight: 16px
  label-sm:
    fontFamily: Inter
    fontSize: 11px
    fontWeight: '500'
    lineHeight: 14px
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  gutter: 1rem
  margin: 1rem
  space-xs: 0.25rem
  space-sm: 0.5rem
  space-md: 1rem
  space-lg: 1.5rem
  space-xl: 2rem
---

## Brand & Style

This design system drives a civic urban navigation and pedestrian safety platform built specifically for walking in Bogotá. The brand personality balances civic empowerment, neighborhood solidarity, and utilitarian navigation precision. It communicates trust, rapid comprehension under direct sunlight or rain, and collective responsibility.

The visual direction follows **Modern Tactical Civic**:
- High-contrast, clean surfaces that elevate spatial orientation over decorative clutter.
- Tactile floating bottom sheets and navigation modules designed for single-hand mobile operation on active city streets.
- Functional iconography and vivid alert tokens that immediately convey infrastructure conditions (pavement health, lighting, walkability, security).
- An approachable yet authoritative utility aesthetic that bridges public open-source reporting and municipal-grade geographic data.

## Colors

The color system delivers high-contrast legibility across dynamic lighting conditions encountered outdoors:

- **Primary (`#2563EB`)**: Electric Cobalt, directly rooted in high-visibility navigation landmarks, map markers, primary calls to action, and route paths. Darker active states utilize `#1D4ED8`.
- **Secondary (`#10B981`)**: Emerald Green, indicating pedestrian-safe zones, verified accessible curb cuts, well-lit night corridors, and confirmed municipal repairs.
- **Tertiary (`#F59E0B`)**: Alert Amber, signaling pedestrian hazards—such as broken slabs ("baldosas sueltas"), open utility holes, construction blockages, and low-light warnings.
- **Neutral (`#0F172A`)**: Deep Slate. Used for high-priority typography, sharp interface iconography, and map pin borders. Soft interface surfaces transition through `#64748B` (secondary copy), `#E2E8F0` (structural hairline borders), and `#F8FAFC` (canvas backing).
- **Surface Elevation**: Modals and bottom sheets sit on `#FFFFFF` with translucent backdrops (`rgba(15, 23, 42, 0.4)`), ensuring map geography remains visually present during modal workflows.

## Typography

Typography prioritizes instant decipherability at arm’s length while in motion.

- **Headlines & Display (Plus Jakarta Sans)**: Contemporary geometric forms with open apertures and balanced proportions, ensuring landmark names and safety metrics stand out cleanly.
- **Body & Captions (Plus Jakarta Sans)**: Generous x-height and clear counters reduce eye fatigue during outdoor reading under variable sunlight.
- **Labels & Microcopy (Inter)**: Applied to metadata chips, severity tags, geolocation coordinates, and quick status pills to guarantee technical clarity and dense tabular balance.
- **Hierarchy Rules**: Numerical indicators, route durations, and safety ratings must use semi-bold or bold weights to allow immediate visual triage within map pins and top-layer cards.

## Layout & Spacing

The layout is strictly mobile-first, engineered around a full-bleed geographic map viewport with dynamic floating UI controls:

- **Viewport Canvas**: The base layer is an interactive interactive map. Floating interface panels and bottom sheets utilize strict safe-area insets (`env(safe-area-inset-bottom)`).
- **Touch Targets**: All interactive elements (filter chips, map buttons, report triggers) enforce a minimum hit target of `48px` to account for single-handed use while walking.
- **Spacing Rhythm**: Built on a modular 4px/8px scale. `space-xs` (4px) defines badge internals; `space-sm` (8px) separates chip icons and text; `space-md` (16px) governs card padding, standard gutters, and edge margins; `space-lg` (24px) manages sheet headers and section breaks.
- **Sheet Heights**: Bottom sheets snap to three distinct heights: Peek (88px, summary info), Half (45vh, hazard list and community comments), and Full (90vh, complete incident submission form).

## Elevation & Depth

Visual hierarchy uses physical layering to distinguish spatial map elements from real-time operational chrome:

- **Level 0 (Map Base)**: Raw map canvas, vector geometry, and ground-level route vectors.
- **Level 1 (Map Overlays & Pins)**: Custom vector pin clusters and safe corridor ribbons, rendered with crisp 1.5px solid `#FFFFFF` borders to pop against streets.
- **Level 2 (Floating Action Shell & Chips)**: Horizontal filter bars and floating quick-actions utilize `#FFFFFF`, a 1px border of `#E2E8F0`, and an ambient diffused drop: `0px 4px 16px -2px rgba(15, 23, 42, 0.08)`.
- **Level 3 (Bottom Sheets & Modal Reports)**: High-priority informational surfaces rise above all map navigation with an ambient shadow: `0px -8px 28px -4px rgba(15, 23, 42, 0.12)`. Glass-filtered backgrounds use `backdrop-filter: blur(12px)` for semi-collapsed summary bars over map content.

## Shapes

The interface embraces organic, friendly curves that soften urban concrete themes without sacrificing utilitarian structure:

- **Standard Elements (Cards & Sheets)**: Formed with `rounded-2xl` (16px) curvature on floating panels and top edges of bottom sheets, creating a welcoming, modern tactile sheet language.
- **Interactive Controls (Inputs & Buttons)**: Inputs and standard action buttons use `rounded-xl` (12px) for structured ergonomic feel.
- **Pills & Chips (Tags & Statuses)**: Filter chips, category indicators, and severity badges use full pill geometry (`rounded-full`) to immediately differentiate them from layout cards.
- **Pin Markers**: Teardrop map pins with circular inner viewports and sharp downward vertices to indicate exact geospatial positions.

## Components

### Buttons
- **Primary Action**: Electric Blue (`#2563EB`) solid fill, white text, bold weight, `rounded-xl`, 48px height. On press: `#1D4ED8`.
- **Secondary Action**: White background, `#E2E8F0` border, `#0F172A` text with subtle hover tint `#F8FAFC`.
- **Destructive/Critical**: Soft Red background (`#FEE2E2`) with `#DC2626` text for false-report flags or hazard cancelation.

### Filter Chips (Accesibilidad, Iluminación, Seguridad, Aceras)
- Default state: `#FFFFFF` fill, 1px `#E2E8F0` border, `#0F172A` text, leading category icon, horizontal scroll container with no scrollbars.
- Active state: `#2563EB` fill, `#FFFFFF` text, subtle elevation shadow, no border.

### Map Pins & Markers
- High-visibility custom marker with colored glyph circle:
  - Blue (`#2563EB`): Community reports, meeting points, verified paths.
  - Amber (`#F59E0B`): Sidewalk obstacles, pothole/broken slab warnings, low-visibility areas.
  - Green (`#10B981`): Safe night corridors, step-free access, functioning pedestrian lights.
- Outer border: 2px solid `#FFFFFF` to ensure distinction against map vector tiles.

### Bottom Sheet Cards
- Fixed to mobile viewport bottom with top corner radii of 24px.
- Includes a centered grab handle (36px wide, 4px thick, `#CBD5E1`).
- Card content features two-column quick stats (e.g., "Reportado hace 12m", "8 votos útiles"), community upvote pill, and an alert severity indicator.

### Citizen Report Form
- **Category Selectors**: 2x2 grid of tactile selection cards containing large thematic vector icons and labels (e.g., "Andén Roto", "Sin Luz", "Obstrucción", "Inseguridad").
- **Severity Toggle**: 3-step segmented pill slider: Leve (Amber-100), Moderado (Amber-300), Crítico (Red-500).
- **Media Upload**: Dashed `#CBD5E1` boundary card with immediate photo preview and geolocation tag auto-fill.

### Input Fields
- Enclosed with a 1px border (`#CBD5E1`), transitioning to a 2px `#2563EB` focus ring with no offset.
- Floating label or compact placeholder text in `#64748B`.
- Integrated suffix buttons for location clearing and GPS centering.