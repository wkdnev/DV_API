### PS-1 — Policy and Procedures (Control)

This requirement is about making sure your organisation has clear, up-to-date rules for protecting people who hold security clearance, and the practical steps to follow those rules. Without a written personnel security policy and supporting procedures, different teams could work in different ways, important legal and regulatory duties could be missed, and lessons from incidents, audits, or changes in the law might not be acted on quickly—leaving the organisation exposed to preventable security and privacy risks.

To meet this expectation, the organisation must develop, document, and share an organisation-wide personnel security policy for roles within the Department of Defence (DoD) personnel security programme and for human resources (HR) and personnel security staff. The policy must explain its purpose, who is responsible for what, management commitment, how different parts of the organisation work together, and how compliance is checked. It must also align with all relevant laws, directives, regulations, and internal guidance.

The organisation must appoint a named Personnel Security Policy Owner within the Security Office. This person is responsible for creating, maintaining, and sharing the policy and procedures with all security-cleared employees, contractors, and relevant supervisors. They must also share the procedures with HR and personnel security staff, personnel security programme managers, and site security leads.

The policy must be reviewed and updated every year, and within 60 days of any event that triggers a change. The procedures must be reviewed and updated every year, and within 30 days of any event that triggers a change. Updates must also be made after security incidents or breaches, audit findings, or changes to the requirements that apply to the organisation.

##### PS-1 policy/procedure lifecycle with PSPO ownership and timed updates

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define PS-1 policy scope, roles/responsibilities (including PSPO), coordination with Security & Privacy, and explicit legal/regulatory alignment mapping (obligations-to-policy statements) | Compliance Manager | Enterprise | 24h | — |
| Draft organisation-level Personnel Security Policy (purpose, scope, management commitment, compliance assurance approach, review/update SLAs, triggering-event governance, dissemination requirements) | Cyber Security Lead | Enterprise | 32h | — |
| Define and draft operational Personnel Security Procedures (step-by-step implementation for HR/Personnel Security staff, security programme managers, and system/OT site security leads), including evidence requirements and escalation paths | Security Engineer | Enterprise | 40h | — |
| Establish PSPO governance model and approval workflow (review cadence, triggering-event intake, approval/ratification steps, version control rules, and audit trail expectations) | Project Manager | Enterprise | 16h | — |
| Configure controlled document lifecycle in the enterprise repository (versioning, approval workflow, audit trail, controlled publication, and access controls for policy/procedure documents) | Platform Engineer | Enterprise | 24h | £3,000 |
| Implement triggering-event workflows and SLAs (policy: annual + within 60 days; procedures: annual + within 30 days) including incident/audit/legal-change linkage to document review actions | Operations Lead | Enterprise | 20h | — |
| Dissemination and acknowledgement evidence capture (SSO-protected intranet page and/or tracked email; record of access/acknowledgement for cleared employees/contractors/supervisors and procedure audiences) | Service Delivery Manager | Enterprise | 16h | £1,500 |
| Produce audit-ready evidence pack template (what auditors will see: published current versions, PSPO appointment record, review/update logs, triggering-event records, dissemination/access evidence, and mapping to obligations) | Compliance Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 184h  
**Total Estimated Cost:** £4,500

###### Actions Required for Compliance

- [ ] Draft and get approval for an organisation-wide personnel security policy, with a named policy owner (PSPO), a clearly defined scope, assigned responsibilities, coordination arrangements, and a compliance map showing how it meets all relevant laws, directives, and regulations.
- [ ] Create personnel security procedures that set out the implementation steps for human resources (HR) and personnel security staff, security programme managers, and site security leads for information technology (IT) and operational technology (OT) sites. Do not repeat the security controls.
- [ ] Set up a controlled document repository for the policy and procedures, with version history, an approval process, and an audit trail.
- [ ] Appoint the Personnel Security Policy Owner (PSPO) in the Security Office and publish their responsibilities for maintaining and sharing the documents.
- [ ] Review and update service-level agreements (SLAs): the policy must be reviewed at least once a year and within 60 days of any triggering event; the procedures must be reviewed at least once a year and within 30 days of any triggering event.
- [ ] Set up a process to capture the trigger events (incidents or breaches, audit findings, and legal or regulatory changes) and link the supporting evidence to the specific policy or procedure updates that are required.
- [ ] Share the current policy with all security-cleared employees, contractors, and supervisors who have personnel security responsibilities. Share the procedures with human resources (HR) and personnel security staff, security programme managers, and site security leads for information technology (IT) and operational technology (OT). Record proof that the documents were accessed and acknowledged.


---

### PS-2 — Position Risk Designation (Control)

This expectation is about making sure every job role in your organisation is clearly labelled with the level of risk it could create, and that the right checks are carried out for the people appointed to those roles. Without this, unsuitable people could be placed in roles where they could cause serious harm through misconduct, or where their access to sensitive information should have been handled more carefully.

To meet this expectation, the organisation must:
- assign a risk level to every job role, and keep an up-to-date record of those risk levels;
- set clear, role-specific screening requirements for anyone filling each role, ensuring the requirements match the role’s responsibilities for handling information;
- review the risk level for each job role at least every 90 days, and update it when the review shows it is no longer accurate, keeping evidence of the reviews and any changes.

##### Maintain a Position Risk Register with 90-day review and screening criteria

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the Position Risk Register data model and minimum required fields (position identifier, job family/role, OPM-aligned risk designation, sensitivity/risk rationale, screening criteria mapping, review metadata, audit trail requirements) | Compliance Manager | Enterprise | 24h | — |
| Create the designation-to-screening mapping (deterministic rules) aligned to OPM Position Designation System concepts, including investigation/screening levels and evidence expectations per level | Compliance Manager | Enterprise | 32h | — |
| Develop screening criteria templates and embed explicit information security role appointment requirements (e.g., IAM administration, security monitoring/SIEM operations, vulnerability management, security engineering, privileged access administration) with attachable “criteria packs” | Data Protection Officer | Enterprise | 40h | — |
| Establish governance process and 90-day review operating model (roles/RACI, triggers, escalation, sign-off, evidence capture standards, exception handling, and linkage to security planning artefacts) | Project Manager | Enterprise | 28h | — |
| Implement the 90-day review workflow and register maintenance procedure (task generation, reviewer decisions, evidence capture, update rules, and audit-ready reporting) using the organisation’s existing GRC/HR workflow approach | Operations Lead | Enterprise | 56h | — |
| Integrate with HRIS/identity onboarding so appointments automatically link to the position risk designation and select the correct screening criteria pack (including validation controls and test cases) | Platform Engineer | Enterprise | 48h | — |
| Add change-trigger flags for earlier re-designation (material duty/responsibility changes) and define how triggers update the register and re-select screening criteria packs | Security Engineer | Enterprise | 24h | — |
| Pilot the end-to-end process for a representative set of positions, remediate gaps, and produce an audit pack demonstrating 90-day review evidence and correct screening criteria application | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 284h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and keep up to date an official Position Risk Register that covers every role in the organisation.
- [ ] Define and get approval for a mapping from job designations to screening criteria, aligned with the Patient Data Standards (PDS) concepts.
- [ ] Add clear requirements for appointing information security roles into the screening criteria templates.
- [ ] Integrate the human resources information system (HRIS) with identity onboarding so that each appointment is linked to the role’s risk rating and the required background-check screening criteria pack.
- [ ] Set up a workflow that triggers and records evidence for position risk designation reviews at least once every 90 days.
- [ ] Keep records of each review (who reviewed it, the date, the result, and any designation or screening updates) so it can be audited.
- [ ] Update the system security planning documents to reference the PS-2 process, the responsible roles, and the evidence sources.


---

### PS-3 — Personnel Screening (Control)

This requirement ensures that the right checks are carried out on people before they are allowed to use the system, and that those checks are repeated when their circumstances change. Without this, someone who should not have access could gain it, or a person’s situation could change in a way that increases risk—leaving the organisation exposed to fraud, misuse, or unauthorised handling of sensitive information.

The organisation must screen every person before granting access, using background checks and other suitable checks. It must also keep records showing that the screening was completed and the date it was completed.

The organisation must rescreen people when required:
- at least every year for anyone who can access **Classified (Secret)** information
- at least every five years for anyone who can access **Confidential** information
- within 30 days after a material change in their role or the risk level of their position, including when someone is terminated and then rehired into a covered role.

##### IAM screening gate with event-driven rescreening SLAs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define screening-to-access mapping (policy-as-code) including Secret/Confidential scope classification and rescreening rule matrix (annual/5-year/30-day triggers) | Compliance Manager | Enterprise | 24h | — |
| Design IAM attribute model and lifecycle (e.g., `screeningDecision`, `screeningLevel`, `screeningExpiry`, `lastRescreenDate`, `triggerReason`) plus data ownership and update semantics | System Design Authority | Enterprise | 32h | — |
| Implement screening status persistence and immutable audit evidence model (per-individual evidence linking screening outcome to provisioning events) | Security Engineer | Enterprise | 40h | — |
| Build event-driven rescreening orchestration (HR/role/risk change + termination/rehire detection, SLA timers, and automated trigger creation) | Platform Engineer | Enterprise | 56h | — |
| Integrate screening workflow with provisioning gate (block initial provisioning and privileged group assignment unless approved and level matches target classification; restrict access when due/expired) | Software Lead | Enterprise | 64h | — |
| Configure IdP/IAM workflows, attribute propagation, and access restriction behaviour for due/expired screening (including minimum-necessary access handling) | DevOps Lead | Enterprise | 40h | — |
| SIEM/logging integration and audit readiness validation (retention alignment, evidence query/runbooks, and end-to-end traceability tests) | Operations Lead | Enterprise | 24h | — |
| Execute test plan and acceptance demonstrations for each trigger type (Secret expiry, Confidential expiry, material role change, material risk designation change, termination+rehire) with remediation of findings | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 312h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create a clear, official mapping of which applications can access which types of data (Secret or Confidential), and specify the rescreening rule that applies.
- [ ] Set up identity and access management (IAM) / identity provider (IdP) screening status details—decision, level, expiry date, last rescreen date, and trigger reason—using information from the screening process.
- [ ] Set up user provisioning and assignment to privileged groups so they are blocked unless the screening decision is **approved** and the screening level meets the required access classification.
- [ ] Set up integration with human resources (HR) events—such as job role changes, changes to risk status, terminations, and rehires—to automatically start re-screening processes. Apply a 30-day service level agreement (SLA) for changes that are considered material.
- [ ] Set up automatic re-checks for **Secret** information (every year) and **Confidential** information (every 5 years). When a re-check is due or has expired, restrict access until the screening is completed.
- [ ] Store unchangeable audit records that link the screening result to the dates when access was completed and approved, and to the access authorisation or provisioning event.


---

#### PS-3.1 — Classified Information (Enhancement)

This requirement ensures that only people who have been properly approved and properly briefed can handle the most sensitive government information. Without it, someone might be allowed to view or work with classified material without the correct level of clearance or without being formally told what they are allowed to access. This increases the risk of unauthorised disclosure, misuse, or accidental mishandling.

To meet this requirement, the organisation must clearly identify which people are allowed to access systems that store, process, or transmit classified information. Before anyone is given access, the organisation must confirm that they have the required security clearance and that they have been formally briefed to the highest level of classified information they are permitted to access on that system.

The organisation must keep clear records of the clearance checks and the briefing level, including the dates. It must repeat the clearance and briefing checks whenever a person’s permitted access level increases.

##### Enforce clearance and highest-level indoctrination before access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and publish the classification-to-access mapping (per environment and per resource type: UI/API/admin), including required maximum classification levels and mover (role increase) rules | System Design Authority | Enterprise | 24h | — |
| Design IdP attribute schema and governance for clearance/indoctrination (e.g., `clearanceLevel`, `clearanceValidUntil`, `indoctrinationLevel`, `indoctrinationCompletedOn`, `clearanceRecordId`, `indoctrinationRecordId`), including attribute update controls and audit requirements | Data Protection Officer | Enterprise | 32h | — |
| Implement IdP integration and conditional access policies to enforce clearance + highest-level indoctrination before authorisation (including session-start re-evaluation where applicable) | IAM Engineer | Enterprise | 56h | — |
| Integrate clearance management and indoctrination/briefing workflows to automatically populate and update IdP attributes with timestamps and provenance; include onboarding and role-change triggers | Security Engineer | Enterprise | 48h | £25,000 |
| Implement application-side authorisation checks for resource requests (UI/API/admin) using the IdP attributes, including denial responses and handling for service accounts via approved human sponsorship governance | Software Lead | Business Unit | 40h | — |
| Configure end-to-end audit logging and evidence generation (correlation IDs, record references, attribute values used, timestamps) and ensure logs flow to SIEM for audit retention | Operations Lead | Enterprise | 32h | £8,000 |
| Document the enforcement in the system security plan (control logic, attribute sources, responsibilities, evidence retention, and operational runbooks for exceptions/appeals) and support compliance review | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 256h  
**Total Estimated Cost:** £33,000

###### Actions Required for Compliance

- [ ] Define the application’s levels of access to classified information, and assign each access role and resource a maximum allowed classification level.
- [ ] Create official identity provider (IdP) attributes for clearance and indoctrination, including the level, validity and completion dates/times, and record references, with strict change control.
- [ ] Link the clearance and indoctrination systems to the identity provider so that updates to user attributes are automated, recorded with the date and time, and their source is kept for audit purposes.
- [ ] Put in place access and authorisation rules that block access unless the person’s clearance and indoctrination are at least as high as the required maximum classification level, and the clearance has not expired.
- [ ] Set up joiner and mover processes so that clearance and security training are reviewed again before giving access to higher-classified resources.
- [ ] Enable audit logging for authorisation decisions, including the attribute values used and how they link to the corresponding clearance and indoctrination record references.
- [ ] Update the system security plan to set out how security rules are applied, which information is used, who is responsible, and how long supporting records are kept.


---

#### PS-3.2 — Formal Indoctrination (Enhancement)

This requirement is about ensuring that only people who have been properly briefed can handle sensitive government information, and that they receive the correct briefing for every type of information they are allowed to access. Without this, someone could be given access to information they have not been formally trained or authorised to understand, which increases the risk of accidental mishandling, unauthorised disclosure, or serious compliance failures.

To meet this expectation, the organisation must first define which types of classified information on the system require formal indoctrination (including Special Access Program, Restricted Data, and Sensitive Compartmented Information). It must then identify everyone who is authorised to access the system and specify exactly which types of information each person is permitted to access.

Before access is granted, each person must complete the formal indoctrination for every relevant type. The organisation must also keep clear, individual records showing that each person has completed the required briefings. The organisation should document this process in its personnel and system plans and be able to check that the required briefings are in place when making access decisions and during reviews.

##### Type-specific indoctrination gating for SAP/RD/SCI access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define indoctrination-required information type taxonomy (SAP/RD/SCI plus any additional types) and map each type to concrete resources (endpoints, datasets, storage locations, admin functions) | System Design Authority | Enterprise | 24h | — |
| Design type-specific entitlement model in IAM (e.g., `SAP_ACCESS`, `RD_ACCESS`, `SCI_ACCESS`) including attribute naming, validity windows, and handling for joiner/mover/privileged paths | Cyber Security Lead | Enterprise | 32h | — |
| Implement secure integration from indoctrination/briefing record source into IdP/authorisation decision service (person-specific completion attributes per type, with integrity controls and reconciliation) | Infrastructure Lead | Enterprise | 56h | £18,000 |
| Configure pre-access gating policies (conditional access/authorisation) to block entitlements and/or resource access unless the corresponding type-specific completion attribute is present and valid | DevOps Lead | Enterprise | 40h | — |
| Develop audit evidence generation (per-user, per-type) including linkage to completion records, entitlement grants, timestamps, and exportable audit reports | Compliance Manager | Enterprise | 24h | — |
| Update system security plan and supporting documentation (PS-3(2) narrative, responsibilities, control operation, exception handling, and evidence sources) | Compliance Manager | Enterprise | 16h | — |
| Execute end-to-end testing and assurance (test cases for missing/expired indoctrination, joiner/mover events, privileged access, and negative authorisation checks) and remediate findings | Quality Assurance Lead | Enterprise | 32h | £6,000 |
| Pilot rollout to a representative set of SAP/RD/SCI resources and users, then transition to BAU monitoring/alerting for gating failures and evidence gaps | Service Delivery Manager | Business Unit | 24h | £4,000 |

**Total Estimated Effort:** 268h  
**Total Estimated Cost:** £28,000

###### Actions Required for Compliance

- [ ] Define a classification system for information that requires indoctrination (at minimum: SAP, RD, and SCI) and link each information type to the relevant application resources.
- [ ] Create separate identity and access management (IAM) permissions for each type of access that requires indoctrination (for example, SAP_ACCESS, RD_ACCESS, SCI_ACCESS).
- [ ] Add completed formal training (indoctrination) records into the identity provider and authorisation service as attributes that are specific to the person and the type of record.
- [ ] Set conditional access and authorisation rules to prevent entitlement being issued and/or access to resources unless the matching “type completion” attribute is valid.
- [ ] Set up joiner and mover processes so that when new or expanded SAP, RD, or SCI access permissions are granted, the system checks that the required pre-access indoctrination has been completed before access is allowed.
- [ ] Create and check audit reports that link every granted entitlement to the correct type-specific completion record and the date it was completed.
- [ ] Update the system security plan to describe the PS-3(2) approval step (gating mechanism) and assign named responsibilities.


---

#### PS-3.3 — Information Requiring Special Protective Measures (Enhancement)

This requirement is about ensuring that only the right people can access systems that hold especially sensitive information, and that those people have been properly checked for the work they are doing. Without this, an unauthorised or unsuitable person could access sensitive material, or someone whose checks are no longer valid could continue working with it. This increases the risk of data misuse, fraud, and serious harm to the organisation and others.

To meet this expectation, the organisation must:
- First, identify which systems hold information that needs special protection.
- Then, set out who is allowed to access those systems based on legitimate official government duties.
- Keep evidence that each person’s access is up to date, approved, and clearly linked to their job.

The organisation must also make sure that anyone who needs access to Secret or Confidential-level information meets the required suitability and background screening standards before access is granted. It must complete and record any required periodic re-checks. If a person’s screening becomes invalid, their access must be suspended or removed unless there is an approved exception that is limited to a specific time period.

##### Screening-validity gate for Secret/Confidential system access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce authoritative “special-protection” system inventory and screening-level mapping (Secret/Confidential) for all in-scope applications/environments | Compliance Manager | Enterprise | 24h | — |
| Define IAM authorisation model: roles/groups, system scopes, and required screening level rules (including exception handling approach and operational windows) | System Design Authority | Enterprise | 32h | — |
| Implement attribute contract and integration with personnel security/HR screening source (API/data feed, attribute schema, validity/reinvestigation/suitability/exception flags) | Security Engineer | Enterprise | 40h | — |
| Configure IdP conditional access policies for sign-in denial and token/session claims based on screening validity for required level | IAM Engineer / Identity Architect | Enterprise | 32h | — |
| Implement automated provisioning and deprovisioning workflows (group/app assignment, suspension when invalid/overdue, and reconciliation job for drift detection) | DevOps Lead | Enterprise | 40h | — |
| Implement auditable evidence capture: access decision logs, provisioning events, linkage between user, system scope, authorisation approval, and screening attributes; integrate with SIEM | Operations Lead | Enterprise | 32h | £8,000 |
| Execute end-to-end testing and operational readiness: test cases for valid/invalid/overdue/exception scenarios across environments; update runbooks and monitoring/alerting | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 240h  
**Total Estimated Cost:** £8,000

###### Actions Required for Compliance

- [ ] Create and keep up to date an official list of special-protection systems, showing the required security screening level (Secret or Confidential).
- [ ] Define identity and access management (IAM) roles and groups that link official job duties to the system areas they can access and the required screening level.
- [ ] Connect the official personnel security and human resources (HR) screening system to the organisation’s identity provider and identity and access management (IAM) system, so that each user’s screening level, validity period, and next required re-screening status are available as user details (attributes).
- [ ] Set up conditional access rules to block sign-ins to special-protection applications when the screening does not meet the required level.
- [ ] Set up automated account access so it is only granted when screening has been approved and is still valid, and is automatically suspended if the screening is invalid or overdue.
- [ ] Enable audit logs for access decisions and user provisioning events, including the screening information used and the final authorisation result.
- [ ] Carry out regular checks to compare who has access (identity and access management) against their current screening status, and fix any differences.


---

#### PS-3.4 — Citizenship Requirements (Enhancement)

This requirement is about making sure only the right people can handle highly sensitive information. In everyday terms, it stops unauthorised or unsuitable people from accessing systems that store, process, or send **Confidential** and **Secret** information. Without this control, there is a risk of serious data leaks, fraud, or harm to customers, partners, or national interests.

To meet this expectation, the organisation must clearly set out who is allowed to access these systems. It must require that every authorised person is either a **United States citizen** or a **lawful permanent resident**, and also holds the specific level of security clearance needed for that access. Before access is granted, the organisation must check both the person’s eligibility and their security clearance. If either requirement is not met, access must be refused or blocked.

The organisation must also keep clear records showing that these checks were completed and when access was authorised. In addition, it must document the screening criteria and the step-by-step process for any further checks required, and ensure these requirements are included in its system plans and access procedures.

##### Pre-access citizenship & clearance gate for Confidential/Secret apps

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define eligibility rule mapping in policy model (app/system tagging for Confidential/Secret → required citizenship + required clearance; include effective/expiry semantics) | System Design Authority | Enterprise | 24h | — |
| Data integration design for authoritative attributes (HR citizenship/LPR + clearance management records) including attribute schema, versioning, effective/expiry handling, and evidence identifiers | Data Protection Officer | Enterprise | 32h | — |
| Implement IdP/access management conditional enforcement (pre-access deny-by-default for missing/stale/unverifiable attributes; token/entitlement gating for Confidential/Secret apps) | Security Engineer | Enterprise | 56h | — |
| Implement auditable entitlement workflow (sequenced approvals; record “citizenship verified” and “clearance verified” with evidence reference/IDs; link to authorisation decision) | Compliance Manager | Enterprise | 40h | — |
| Exception handling and remediation automation (quarantine/deny state; create remediation tickets; define resolution criteria and re-validation triggers) | Operations Lead | Enterprise | 24h | — |
| Continuous reconciliation & revocation (scheduled re-validation; automatic revocation on clearance downgrade/expiry or citizenship eligibility change; evidence retention alignment) | DevOps Lead | Enterprise | 32h | £12,000 |
| End-to-end testing and audit readiness (test cases for deny/allow, stale attributes, evidence linkage, workflow sequencing; produce audit pack and runbook) | Quality Assurance Lead | Enterprise | 32h | £5,000 |

**Total Estimated Effort:** 264h  
**Total Estimated Cost:** £17,000

###### Actions Required for Compliance

- [ ] Label all systems that process, store, or transmit **Confidential** or **Secret** information with the required citizenship and security clearance rules.
- [ ] Add employment and long-term residence (LPR) details, along with official clearance records, to the central identity governance system, including the start and end dates (effective and expiry dates).
- [ ] Set up identity provider (IdP) conditional access (or an equivalent control) to block sign-ins and the issuing of access tokens to “Confidential” or “Secret” applications unless both citizenship eligibility and the required security clearance have been verified.
- [ ] Set up an approval process for access requests that records the evidence used to verify citizenship and clearance, and only marks the access as approved after those checks have been completed and the evidence references have been recorded.
- [ ] Apply a “deny by default” rule when citizenship or clearance information is missing, out of date, or cannot be verified, and raise remediation tickets to fix the issue.
- [ ] Set up regular re-checks of eligibility and automatically remove access when eligibility changes (for example, when a security clearance is downgraded or expires, or when citizenship status changes).


---

### PS-4 — Personnel Termination (Control)

This requirement is about stopping a person’s access as soon as their job ends, and making sure nothing valuable or sensitive is left behind. Without it, a former employee could still access systems, use old cards or keys, or keep control of information and tools they should no longer manage. This creates a real risk of unauthorised access, misuse of data, or loss of security assets.

Within 1 hour of employment ending, the organisation must switch off the person’s access to organisational systems and remove every way they could prove who they are. This includes digital access, as well as physical items such as keys, identification cards, building passes, and security tokens. The organisation must also get back all security-related property the person had, and hold an exit interview where practicable. The exit interview should cover ongoing responsibilities under non-disclosure agreements, the need to return security items, how classified information must continue to be protected, and any limits on future employment.

Finally, the organisation must make sure that any information and systems the person previously controlled remain protected and are managed by the organisation. It must keep proper records of what was done.

##### HR-driven termination workflow to disable access within 1 hour

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define termination-to-access-off target, workflow states, SLAs (incl. “within 1 hour”), and evidence requirements (HR timestamp, disable time, session/MFA revocation, property-return, exit-interview outcomes) | Compliance Manager | Enterprise | 16h | — |
| Design and implement HR termination event model (authoritative termination timestamp + reason), including secure event publishing to IAM and downstream systems | System Design Authority | Enterprise | 24h | — |
| Implement IdP deprovisioning automation: disable account, revoke active sessions/refresh tokens, remove/disable MFA factors (incl. FIDO2/authenticator/SMS-voice where used) and enforce immediate block via conditional access/session controls | Security Engineer | Enterprise | 40h | £15,000 |
| Build downstream access and role removal orchestration: remove/transfer app roles, group memberships, service account ownership, and administrative privileges; ensure former user retains zero authorisations post-disable | Platform Engineer | Enterprise | 32h | £5,000 |
| Create credential/property revocation workflow integration (Security/Facilities/IT work orders) for hardware authentication tokens, keys, identification cards, building passes, and system administration technical manuals; maintain property-return status list linked to termination case | Operations Lead | Enterprise | 24h | £3,000 |
| Implement “exit interview where practicable” checklist integration with conditional logic (practicable vs non-practicable), required security topics, and documented rationale + alternative accountability mechanism | Data Protection Officer | Enterprise | 16h | — |
| Generate audit-ready evidence bundle and reporting: immutable audit trail, timestamp correlation, affected systems/apps/roles, property-return outcomes, and exit-interview completion/non-practicability rationale; include SIEM-ready logs | Cyber Security Lead | Enterprise | 24h | £8,000 |
| Execute end-to-end testing and go-live readiness: termination simulation, timing verification (≤1 hour), MFA/session revocation validation, role-transfer validation, property-return workflow dry runs, and operational runbook/training | Project Manager | Enterprise | 32h | £2,000 |

| Total Estimated Effort | 208h |  |
|---|---:|---:|
| Total Estimated Cost |  | £33,000 |

###### Actions Required for Compliance

- [ ] Set up the process for ending access so that system access is turned off during the agreed time window (target: within 1 hour of termination).
- [ ] Connect human resources (HR) staff termination records to the organisation’s identity provider (IdP) so that, automatically, user accounts are disabled, active sign-in sessions and refresh tokens are revoked, and multi-factor authentication (MFA) methods are removed or disabled.
- [ ] Use conditional access and session controls to block access immediately, so access is prevented before the next sign-in.
- [ ] Create and link work orders to retrieve property used for hardware authentication tokens, keys, identification cards, building passes, and system administration technical manuals.
- [ ] Set up an exit-interview checklist “gate” that confirms, with records, that employees understand and comply with: their non-disclosure agreement (NDA) obligations; returning any security-related property; continuing to protect classified information; and restrictions on future employment. Include documented steps for cases where any part is not practical to carry out.
- [ ] Automate the removal or transfer of the leaver’s application roles, group memberships, and administrative privileges.
- [ ] Create an evidence bundle showing: the time the employee’s employment ended, the time access was disabled, the time multi-factor authentication (MFA) and session access were revoked, which systems and job roles were affected, whether company property has been returned, and the result of the exit interview.


---

#### PS-4.1 — Post-employment Requirements (Enhancement)

This requirement is about making sure that when someone leaves the organisation, they are clearly told what they must do after they go, and that they confirm they understand it. Without this, a leaver could accidentally or deliberately misuse or share the organisation’s information, which could cause legal, financial, and reputational harm to the business.

To meet this expectation, the organisation must keep an up-to-date list of the post-leaving obligations that apply to each person, and make sure those obligations can be enforced in law (for example through contract terms, legislation, or other binding agreements). During the exit process, the organisation must give the departing individual a written notice of the obligations that apply to them before they leave or at the time they leave, and require them to sign a confirmation that they received and understood what they were told.

The organisation should also have clear internal procedures for ending employment, assign named responsibilities for handling this, record the approach in its security planning, and involve its legal advisers to confirm which obligations are legally binding.

##### Versioned post-employment requirements pack with signed acknowledgement

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the authoritative, versioned “post-employment requirements list” schema (fields, legal basis references, region/role/contract-type mapping, effective dates) and establish controlled lifecycle (create/change/retire) | Information Security | Enterprise | 24h | — |
| Establish Legal validation workflow for the requirements list and templates (approval steps, evidence requirements, version approval records, audit retention expectations) | Compliance Manager | Enterprise | 16h | — |
| Produce legally validated notice and acknowledgement templates (including legal basis/version references, data handling obligations, signature instructions, and retention wording) | Data Protection Officer | Enterprise | 20h | — |
| Implement HRIS termination workflow integration to select applicable obligations based on employee attributes and to generate the requirements pack at termination initiation (with correct version binding) | Platform Engineer | Enterprise | 56h | — |
| Implement e-signature gating and audit trail capture (block exit completion until acknowledgement recorded; store signer identity, timestamp, document hash/version, and workflow timestamps) | DevOps Lead | Enterprise | 48h | £18,000 |
| Implement termination record evidence retention (notice version, requirements list version, acknowledgement form version, signature metadata, and pack generation timestamps) and ensure audit-ready retrieval | Operations Lead | Enterprise | 24h | — |
| Run end-to-end test, security review, and pilot with HR and Legal (including 100% pack generation checks, failure-mode handling, and evidence sampling for audit) | Quality Assurance Lead | Enterprise | 32h | £3,000 |
| Total Estimated Effort |  |  | **220h** |  |
| Total Estimated Cost |  |  |  | **£21,000** |

###### Actions Required for Compliance

- [ ] Create a version-controlled list of post-employment requirements and get approval from the Office of the General Counsel for each requirement and each template.
- [ ] Set up the human resources (HR) termination process so it automatically chooses the correct obligations based on employee details, such as contract type, access level, the types of data involved, and the employee’s region.
- [ ] Create a written requirements pack (notice plus acknowledgement form) using only the latest versions that have been approved by Legal.
- [ ] Enable electronic signatures for the acknowledgement, and require a workflow step so exit completion cannot be completed without a signature.
- [ ] Store the evidence for termination in the termination record, including the notice version, the requirements list version, the acknowledgement version, the signature details, and the dates and times.
- [ ] Publish and keep up to date the staff termination procedure, and assign named owners for the human resources (HR) staff security responsibilities and the information security responsibilities. Then refer to this procedure in your security planning.


---

#### PS-4.2 — Automated Actions (Enhancement)

This expectation ensures that when someone leaves the organisation, the correct people are alerted automatically and the person’s access is removed automatically as well, without relying on anyone to remember to do it. Without this, there is a real risk that the human resources (HR) team and the IT security team are told too late—or not at all—and that the departing employee could still access systems and information for longer than intended. This creates opportunities for mistakes or misuse.

To meet this expectation, the organisation must use automated processes, aligned with its own exit procedures, to:
- send prompt alerts to the HR team and the IT security roles for the specific type of departure, and
- automatically disable the individual’s access to the relevant system resources for those same departure actions.

The information system owner is responsible for making sure these automated actions are in place, correctly set up, documented, and supported by records showing that notifications and access changes were completed for each departure event.

##### HR leaver workflow to auto-notify HR/Sec and disable access

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Confirm termination event contract (termination reference, employee identifier, action type, effective time) and map authoritative HRIS source to orchestration trigger | Compliance Manager | Enterprise | 16h | — |
| Implement orchestration “leaver” workflow (event listener, correlation keys, idempotency, no manual start) in the integration/orchestration layer | Platform Engineer | Enterprise | 40h | — |
| Configure automated notifications to defined HR and IT Security recipients (templates, delivery channels, inclusion of termination reference and effective time) | Security Engineer | Enterprise | 24h | — |
| Implement automated access disabling in IdP and downstream authorisation layers (disable account, remove group/entitlements, revoke sessions/tokens, enforce sign-in block/conditional access) | IAM/Identity engineering lead | Enterprise | 56h | — |
| Implement evidence and correlation (workflow execution logs, notification delivery records, correlation IDs; ensure alignment with IdP audit logs and retention requirements) | Cyber Security Lead | Enterprise | 24h | — |
| Add operational controls (retry policy, failure alerting/escalation, SLA/promptness expectation, runbooks, and monitoring dashboards) | Operations Lead | Enterprise | 24h | — |
| Execute end-to-end testing and readiness (test cases for multiple termination action types, failure scenarios, rollback/compensating actions, and audit evidence verification) | Quality Assurance Lead | Enterprise | 32h | — |

Total Estimated Effort: **236 Hours**  
Total Estimated Cost: **£0**

###### Actions Required for Compliance

- [ ] Define the official human resources (HR) termination message details—termination reference, employee identifier, termination action type, and effective date/time—and make sure the HR information system (HRIS) sends it reliably.
- [ ] Set up an automated “leaver” process that starts automatically when Human Resources records an employee termination, without anyone having to start it manually.
- [ ] Set up automated notifications to the agreed human resources (HR) and information technology (IT) security contacts. Each notification should include the termination reference, the employee identifier, the type of action, and the effective date and time.
- [ ] Set up automated account disabling in the identity provider (IdP) and identity and access management (IAM) system for the same employee identifier and termination reference. This should include disabling the account, removing access rights and group memberships, ending any active sessions and cancelling any access tokens, and blocking sign-in where applicable.
- [ ] Enable logging of workflow activity, and link (correlate) those workflow logs with identity provider (IdP) audit logs and notification delivery logs for each termination event.
- [ ] Test the full end-to-end process for several types of termination actions and confirm that the response times meet the organisation’s expectations for its termination procedure.


---

### PS-5 — Personnel Transfer (Control)

This requirement ensures that when someone changes job roles, they only keep the access they genuinely need, and any access from their previous role is removed quickly. If this is not done, the person could still be able to enter buildings or use systems they no longer need, or they could have the wrong permissions. This can lead to mistakes, unauthorised access, or disruption to day-to-day work.

For every permanent or long-term reassignment, the organisation must:
- Review and confirm that the person’s current building and system access is still needed for their new role.
- Within 24 hours of the formal transfer, remove old access, issue new keys, cards, or passes where required, close old system accounts and create new ones if they are used, update what the person is allowed to do, and move access to any official records they need for the new role.

The organisation must also update access if operational needs change, and notify the owner responsible for the affected systems and the facility security officer within 24 hours. It must keep records showing what was checked and what was changed.

##### Automated transfer access lifecycle with 24-hour SLA

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design end-to-end transfer access lifecycle workflow (HRIS trigger → IAM orchestration → SLA enforcement → evidence + notifications) including state model, retries, and failure modes | IAM/Identity Engineering Lead | Enterprise | 40h | — |
| Implement HRIS event ingestion and authoritative trigger (event bus/workflow engine integration), including timestamp normalisation and idempotency controls | Platform Engineer | Enterprise | 32h | £12,000 |
| Build auditable role-to-access mapping service (role/access matrix per application and physical access where API-integrated) and implement before/after entitlement delta computation | Architect | Enterprise | 48h | — |
| Develop access lifecycle actions: revoke old logical access, disable sessions/tokens where supported, issue new entitlements, and close/create accounts per account model | Software Lead | Enterprise | 56h | — |
| Integrate physical access issuance/revocation (badge/PACS) with automated key/card/pass lifecycle where available; implement exception path for non-integrated facilities | Security Engineer | Enterprise | 40h | £25,000 |
| Implement 24-hour SLA orchestration controls (timers, queueing, escalation, and operational dashboards) and ensure completion/exception handling meets acceptance criteria | DevOps Lead | Enterprise | 32h | £8,000 |
| Implement official records access transfer (repository/case/document permissions) under new account context, with least-privilege enforcement and automated validation checks | System Design Authority | Enterprise | 32h | — |
| Implement audit-ready evidence capture and notification delivery within 24 hours (workflow logs, before/after entitlements, notification timestamps, recipients: information system owner + facility security officer) | Compliance Manager | Enterprise | 40h | £6,000 |

**Total Estimated Effort:** 320h  
**Total Estimated Cost:** £51,000

###### Actions Required for Compliance

- [ ] Add human resources information system (HRIS) transfer and reassignment events into an identity and access management (IAM) orchestration process, using a formal transfer date and time.
- [ ] Create and keep a record that can be audited showing which roles have access to which systems, including the change in access rights before and after each update, for every application and every integrated physical access system.
- [ ] Set up the workflow so it completes certificate revocation, user provisioning, privilege updates, and account changes within a strict 24-hour service-level agreement (SLA).
- [ ] Set up an automated process to copy the official-record access permissions to the new account context, or create documented, auditable exceptions for any permissions that must be handled manually.
- [ ] Set up automated notifications to the information system owner and the facility security officer within 24 hours of any reassignment or transfer.
- [ ] Enable audit logging to record the review result, the entitlements before and after the change, the time the action was taken, and proof that notifications were sent.
- [ ] Add a trigger after the transfer to re-check and re-run the mapping when operational needs change


---

### PS-6 — Access Agreements (Control)

This requirement is about making sure that everyone who is permitted to use the organisation’s information and systems has clearly agreed, in writing, to follow the rules. Without current, signed agreements, people may misunderstand what is expected, handle sensitive information in the wrong way, or keep access they no longer need after their duties change. This increases the risk of data leaks, misuse, and unauthorised access.

The organisation is expected to create and keep written access agreements for its information and systems. This includes the relevant types, such as non-disclosure agreements, acceptable use agreements, rules of behaviour, and conflict-of-interest agreements. These agreements must be reviewed and updated at least every 90 days, and also whenever changes are needed or when someone’s role changes.

Anyone who needs access must sign the appropriate agreement before access is granted. They must also re-sign when agreements are updated or when their role changes, and the organisation must keep records of reviews, updates, and re-signing.

##### Agreement-gated access with 90-day re-sign enforcement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define agreement types, application/system role mapping, and acknowledgement text (incl. NDA, acceptable use, rules of behaviour, conflict-of-interest) | Compliance Manager | Enterprise | 40h | — |
| Establish governed, versioned agreement repository (immutable history, unique identifiers, effective dates, approval workflow, access controls) | System Design Authority | Enterprise | 56h | £8,000 |
| Configure IdP/IAM pre-provisioning gating for e-signature acceptance (block provisioning until correct agreement version is signed; support electronic signature where permitted) | Identity Engineering | Enterprise | 72h | £25,000 |
| Implement 90-day review cycle and re-sign enforcement (automated detection of expired agreement versions; block access or remove mapped role membership until re-signed) | Security Engineer | Enterprise | 64h | — |
| Integrate role-change triggers from HRIS/IAM role assignment changes to agreement re-sign requirements (require e-signature before new mapped role becomes active) | Platform Engineer | Enterprise | 48h | — |
| Build audit-ready evidence generation and retention (per signer/version/type/timestamp/method/acknowledgement text/reason; export to SIEM/audit store; retention alignment) | Operations Lead | Enterprise | 40h | £6,000 |
| Test, pilot, and operationalise (test cases for pre-access gating, re-sign on update, re-sign on role change, edge cases; runbook, monitoring/alerts, user comms) | Project Manager | Enterprise | 48h | £3,000 |

**Total Estimated Effort:** 368h  
**Total Estimated Cost:** £42,000

###### Actions Required for Compliance

- [ ] Define the agreement templates (non-disclosure agreement (NDA), acceptable use, rules of behaviour, and conflict of interest) and the required acknowledgement wording.
- [ ] For each application or system role, record the required agreement type(s) and the agreement version identifier.
- [ ] Set up the organisation’s identity provider (IdP) and identity and access management (IAM) process so that user account provisioning is paused until the user signs the correct version of the agreement electronically (e-sign).
- [ ] Set up an automated 90-day review process for each agreement, and publish updated versions with new effective dates.
- [ ] Set up re-sign enforcement so that when an agreement is updated, the affected users’ access expires until they re-sign the updated version.
- [ ] Link human resources information system (HRIS) and identity and access management (IAM) role-change events to trigger a requirement for the user to re-sign when the user’s mapped agreement set changes.
- [ ] Turn on audit logging and keep those records for signing and re-signing events, including the signer’s identity, the agreement version, the date and time, and the reason.


---

#### PS-6.2 — Classified Information Requiring Special Protection (Enhancement)

This requirement is about making sure only the right people can access the most sensitive, specially protected information. Without these checks, confidential material could be viewed by someone who does not genuinely need it, by someone who has not been properly assessed, or by someone who has not clearly agreed to keep it secret—potentially causing serious harm to people, day-to-day operations, and national interests.

To meet this expectation, the organisation must first define which information it treats as specially protected. It must then allow access only when all three of the following conditions are met:

- The person has valid access authorisation that is justified by their assigned official duties.  
- The person has passed the required personnel security checks set out in the relevant rules and policies.  
- The person has read, understood, and signed a non-disclosure agreement before access is granted.

The organisation should also keep clear records showing that each of these conditions has been satisfied for every person given access.

##### Enforce an access triad gate for collateral/SAP/SCI data

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define triad gate model: special-protection entitlements (collateral/SAP/SCI), resource mapping (apps/APIs/db/schema/UI routes), and attribute requirements (duty justification ref, authorisation status, personnel security status, NDA evidence refs) | System Design Authority | Enterprise | 24h | — |
| Design identity attribute integration: data contracts, source-of-truth decisions, attribute validation rules, and handling for missing/expired/contradictory attributes | Architect | Enterprise | 32h | — |
| Implement central authorisation gate: deny-by-default enforcement in the application/authorisation service, including policy logic requiring all three prerequisites simultaneously | Software Lead | Enterprise | 56h | — |
| Implement evidence capture: immutable audit evidence pointers/hashes for each prerequisite, correlation IDs per access grant, and evidence schema aligned to audit requirements | Security Engineer | Enterprise | 32h | — |
| Integrate with SIEM/logging pipeline: forward triad gate events, configure retention/tamper-evidence controls, and validate end-to-end log integrity | Operations Lead | Enterprise | 24h | £8,000 |
| Implement automated revalidation & revocation: session/entitlement expiry, scheduled re-check aligned to clearance/NDA validity, and immediate revocation on attribute invalidation | DevOps Lead | Enterprise | 40h | — |
| Testing & assurance: build test cases (including negative tests), run security regression, produce audit-ready test evidence, and obtain sign-off against acceptance criteria | Quality Assurance Lead | Enterprise | 32h | £3,000 |
| Deployment & operational readiness: release to test/prod, update runbooks/monitoring alerts, define incident/exception handling, and train IAM/security operations on triad gate evidence | Service Delivery Manager | Enterprise | 24h | — |

Total Estimated Effort: **264h**  
Total Estimated Cost: **£11,000**

###### Actions Required for Compliance

- [ ] Define the collateral, SAP, and SCI access permissions (entitlements) and link each entitlement to the application resources it must protect.
- [ ] Integrate identity details to support duty-based authorisation status, personnel security approval status, and proof that a non-disclosure agreement (NDA) has been signed
- [ ] Set up the application and authorisation check so access is refused unless all three “triad” attributes are valid at the same time.
- [ ] Set up tamper-proof audit logs that record the evidence references needed to justify duties, support personnel security decisions, and confirm completion of the non-disclosure agreement (NDA) for each access grant.
- [ ] Set up automatic checks and removal of access so that access is withdrawn as soon as any required condition in the triad expires or is no longer valid.
- [ ] Run tests that check both allowed and blocked access to confirm that if any one required prerequisite is missing, access is denied.


---

#### PS-6.3 — Post-employment Requirements (Enhancement)

This expectation is about making sure people are clearly told, before they are given access, what they must do to protect the organisation’s information even after they leave, and that they formally agree to it. Without this, a departing employee or contractor could later claim they were not aware of their ongoing responsibilities, and the organisation could find it harder to enforce rules on keeping information confidential, returning or destroying it, and other legally binding obligations—putting sensitive information at risk.

To meet this expectation, the organisation must keep an up-to-date list of the legally binding post-employment requirements that apply to different roles, decide which individuals are covered, and tell each person the specific requirements before their initial access is granted. Where a formal acknowledgement is required, the organisation must obtain the person’s signed confirmation before access is provided, and keep the signed record on file. The organisation should also involve its legal team when deciding which post-employment requirements apply.

##### IAM access gating for post-employment obligations with signed acknowledgement

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish OGC-led post-employment requirements catalogue governance (versioning, approval workflow, effective dates, and change control) | Compliance Manager | Enterprise | 24h | — |
| Create/maintain initial version-controlled catalogue of post-employment obligations (by role/contract type/access category) with OGC-approved wording and “signed acknowledgement required/not applicable” flags | Data Protection Officer | Enterprise | 40h | — |
| Implement role-to-requirements mapping in IAM/authorisation layer (including logic for acknowledgement requirement determination and “not applicable” rationale capture) | IAM/Identity Engineering | Enterprise | 56h | — |
| Build pre-access notification pack generation and delivery (catalogue version, effective date, obligation text, delivery/receipt evidence capture) | Platform Engineer | Enterprise | 48h | — |
| Implement identity-verified e-acknowledgement flow in the enterprise IdP (timestamp, signer identity, immutable storage, and linkage keys) | Security Engineer | Enterprise | 64h | — |
| Enforce hard access gating in the access workflow (block completion of initial access until acknowledgement exists or approved “not applicable” record is present) | Operations Lead | Enterprise | 40h | — |
| Implement audit evidence linkage and reporting (access authorisation record references notification evidence + signed acknowledgement evidence; produce auditor-ready extracts) | Cyber Security Lead | Enterprise | 32h | — |
| Conduct end-to-end testing and pilot across sample roles/contract types (including negative tests for missing acknowledgement and catalogue version mismatches) | Quality Assurance Lead | Enterprise | 40h | £12,000 |
| Total Estimated Effort |  |  | **344h** |  |
| Total Estimated Cost |  |  |  | **£12,000** |

###### Actions Required for Compliance

- [ ] Create an Office of Government Commerce (OGC)-reviewed, version-controlled list of post-employment requirements, organised by job role, contract type, and access category.
- [ ] Link identity and access management (IAM) roles and groups to the catalogue entries, and state whether a signed acknowledgement is required or not applicable.
- [ ] Set up the access request process so that, before any initial access is granted, a customised notification pack is created and sent to the relevant people.
- [ ] Set up identity-verified electronic acknowledgement capture (date and time, who signed, and write-once storage that cannot be changed) wherever an acknowledgement is required.
- [ ] Put a strict access check in place so that initial access cannot be approved or completed unless the required acknowledgement record has been captured.
- [ ] Link the evidence IDs for notification and acknowledgement to the access request and approval record so they can be reported for audit purposes.


---

### PS-7 — External Personnel Security (Control)

This requirement is about making sure that people working for outside organisations are properly checked before they are given access, and that their access to your sites and systems is removed quickly when they change jobs or leave. Without clear rules, an external worker could continue using an organisation badge or access rights after they have moved on, or the wrong people could be given access in the first place. This increases the risk of unauthorised access, fraud, or misuse of data.

To meet this expectation, the organisation must:
- define and document clear responsibilities for personnel security for external providers;
- require those providers to follow the organisation’s own personnel security procedures; and
- include these expectations in relevant contracts and procurement documents.

The organisation must also require external providers to notify the Facility Security Officer and the Information System Security Manager within 24 hours of any transfer or termination of external personnel who:
- hold organisation-issued badges or credentials, and/or
- have system privileges.

Finally, the organisation must actively monitor and check that external providers are complying with these personnel security requirements.

##### External provider personnel security addendum with 24h dual-notify

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft controlled “External Personnel Security” reporting criteria document (functions/roles; credential/badge and system-privilege characteristics; definition of reportable transfers/terminations; evidence fields required) | Compliance Manager | Enterprise | 24h | — |
| Produce External Personnel Security addendum template including explicit dual-notify clause to Facility Security Officer and Information System Security Manager within 24 hours for reportable events | Security Engineer | Enterprise | 16h | — |
| Define and publish contract/procurement embedding requirements (clause reference, mandatory inclusion rules, and procurement workflow rejection criteria when addendum/equivalent is missing) | Project Manager | Enterprise | 20h | — |
| Update contract/SOW/SLAs pack and supporting guidance (standard wording, examples, and mapping to external personnel security procedures) for procurement and commercial teams | Operations Lead | Enterprise | 12h | — |
| Operationalise monitoring and evidence cadence (provider evidence submission schedule, acceptable evidence types, review workflow, corrective-action tracking and escalation triggers) | Compliance Manager | Enterprise | 20h | — |
| Establish internal triage and accountability process (Facility Security Officer + Information System Security Manager intake, 24-hour handling workflow, downstream access termination verification with IAM/Security Ops) | Service Delivery Manager | Enterprise | 18h | — |
| Pilot with at least one active external provider engagement and record acceptance evidence (contract inclusion check, test notification within 24 hours, evidence review outcome, lessons learned) | Project Manager | Business Unit | 16h | — |
| Rollout and training for procurement/commercial and relevant security owners (awareness of reportable criteria, dual-notify obligations, and evidence expectations) | Compliance Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 138h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Set clear rules for when external staff must have their access transferred or ended, based on the type of badge or credential they have and the level of permissions they have on the systems.
- [ ] Create a template for an external personnel security addendum that includes a 24-hour dual notification requirement to the Facility Security Officer and the Information System Security Manager.
- [ ] Update procurement contract, statement of work (SOW), and service level agreements (SLAs) templates to require the addendum (or equivalent clauses) for all external providers covered by scope.
- [ ] Set up a procurement approval checkpoint that blocks any contract that does not include the required addendum (or an equivalent personnel security notification).
- [ ] Give responsibility for confirming receipt of internal notifications and for triaging them to the Facility Security Officer and the Information System Security Manager.
- [ ] Require providers to submit verifiable records showing how credentials and access privileges are created, changed, and removed, and provide sample notifications, on a set schedule. Review these submissions.
- [ ] Monitor and fix any provider non-compliance by recording the corrective actions taken and managing the contract accordingly.


---

### PS-8 — Personnel Sanctions (Control)

This requirement ensures that serious breaches of your organisation’s rules for handling information and protecting people’s privacy are dealt with through a clear, formal disciplinary process. Without this, staff may ignore important duties, which could lead to avoidable data leaks, misuse of sensitive information, and legal or reputational harm that could have been prevented.

The organisation must set out in its people and workplace procedures when a formal sanctions process should be started for failing to follow information security and privacy rules, and it must keep records to ensure the process is applied consistently.

Once the formal process is started, it must notify the Office of the General Counsel, the Chief Information Security Officer, and the HR Director within 24 hours. The notification must name the person involved and state the specific reason for the sanction.

This approach should also be reflected in relevant staff agreements and policies, and legal advice should be sought where required.

##### HR sanctions workflow with 24-hour Legal/CISO/HR notifications

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define sanctions trigger taxonomy for information security and privacy non-compliance, including mapping to workflow “reason” categories and required evidence types | Compliance Manager | Enterprise | 24h | — |
| Produce documented workflow specification for “Formal Personnel Sanctions” (mandatory fields, status model, legal consultation/approval gate, non-bypass controls, and notification content requirements) | Project Manager | Enterprise | 32h | — |
| Configure HR case management/HRIS workflow: create “Formal Personnel Sanctions” case type, implement mandatory fields (sanctioned identifier, role/department, trigger category, specific reason, evidence references, initiation timestamp) | HRIS/Workflow Administrator (with Security/Privacy input) | Department | 40h | — |
| Implement workflow gates/approvals to prevent bypass (e.g., investigation complete / Legal consultation gate) and enforce controlled transition to “Formal sanctions process initiated” | System Design Authority | Department | 24h | — |
| Automate 24-hour notifications on status transition (to Office of the General Counsel, CISO, HR Director) including identity, specific reason, and initiation timestamp; ensure message templates meet legal/privacy requirements | Security Engineer | Enterprise | 32h | — |
| Enforce 24-hour SLA with timer, escalation, re-send logic if delivery not confirmed, and capture delivery artefacts (message IDs/ticket references) back into the case record | DevOps Lead | Enterprise | 24h | — |
| Implement audit-ready retention and reporting: ensure case record includes initiation timestamp, reason, evidence references, notification timestamps, recipients, and delivery artefacts; provide an export/report view for audits | Compliance Manager | Enterprise | 16h | — |
| Update relevant access agreements / acceptable use / rules of behaviour / privacy notices to reference the formal personnel sanctions process as the authoritative route | Data Protection Officer | Enterprise | 16h | — |

**Total Estimated Effort:** 208h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define and document the specific situations (“sanctions triggers”) that indicate information security and privacy non-compliance, and include these in the personnel security and privacy procedures.
- [ ] Set up an employee case management process in the HR system with required details for the person’s identity, the specific reason for the case, references to supporting evidence, and the date and time the case was started.
- [ ] Set up a controlled workflow checkpoint so that “formal sanctions process initiated” becomes an auditable status change that cannot be bypassed.
- [ ] Set up automated notifications to the Office of the General Counsel, the Chief Information Security Officer (CISO), and the Human Resources (HR) Director when the “formal sanctions process initiated” event occurs, including the individual involved and the reason.
- [ ] Set a 24-hour service-level agreement (SLA) for sending notifications, with escalation and re-sending if needed, and keep records of delivery evidence in the case.
- [ ] Update the relevant access agreements and security and privacy policies to refer to the formal personnel sanctions process.
- [ ] Run the workflow from start to finish and provide sample audit records showing that it starts and sends notifications within 24 hours.


---

### PS-9 — Position Descriptions (Control)

This requirement is about making sure every job description clearly states the security and privacy responsibilities of the person in that role. If this is not done, people may not understand what they need to do to protect company systems and information, or how to handle personal data lawfully and carefully. This increases the risk of avoidable incidents, such as unauthorised access, mishandling sensitive information, or failing to meet privacy obligations.

To meet this requirement, the organisation must include security and privacy responsibilities in all job descriptions, including specific duties for roles involved in personnel security, information security and privacy, or human resources and workforce management. The organisation must then use these written responsibilities to decide what security and privacy training each role needs. It must also keep clear, documented procedures for adding, reviewing, and updating these responsibilities when roles change.

Finally, the organisation must keep evidence showing that the responsibilities and the linked training needs have been recorded properly and are easy to understand.

##### HR position-description template with security/privacy duty & training links

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish a controlled **Security & Privacy Responsibility Library** with approved responsibility statements and required training-module mappings (including “none” options with required justification fields) | Cyber Security Lead | Enterprise | 24h | — |
| Establish a controlled **Privacy Responsibility Library** with approved responsibility statements and required training-module mappings (including “none” options with required justification fields) | Data Protection Officer | Enterprise | 20h | — |
| Draft and publish the updated **HR position-description template** sections for Security responsibilities, Privacy responsibilities, mapped training(s), and mandatory owner sign-off fields (with audit-friendly wording) | Compliance Manager | Enterprise | 16h | — |
| Define and document the **governance workflow** in HR tooling/process: mandatory Security sign-off and/or Privacy sign-off before finalisation when responsibilities are selected (including validation rules for “none” with reason) | Project Manager | Enterprise | 20h | — |
| Implement the **repeatable procedure** for creating/reviewing/updating position descriptions on role changes (new roles, role changes, contractor/partner updates), including re-validation of responsibility selections and training mappings | Operations Lead | Enterprise | 16h | — |
| Integrate HR role attributes with the **LMS/training assignment mechanism** so mapped security/privacy training is assigned based on the approved position description (including handling for “none” cases) | DevOps Lead | Enterprise | 24h | £6,000 |
| Define and implement **audit evidence retention** requirements: versioning of position descriptions, workflow completion/sign-off records, and training assignment/completion snapshots tied to the approved responsibilities | Compliance Manager | Enterprise | 12h | — |
| Run pilot and acceptance testing: validate 100% completion of required sections, correct training mapping per responsibility, and enforced sign-off gates; remediate findings and finalise rollout guidance | Quality Assurance Lead | Enterprise | 18h | — |

**Total Estimated Effort:** 150h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Create a controlled “Security and Privacy Responsibility Library” that links each responsibility to the required training.
- [ ] Update the human resources (HR) job description template to require security responsibilities and privacy responsibilities, including an explicit statement of “none” where applicable and the reason why.
- [ ] Set up the human resources (HR) process so that the Security and Privacy owners must approve sign-off before position descriptions can be finalised.
- [ ] Define and document a process to review and update who is responsible for what, and which training each role needs, whenever job roles change.
- [ ] Link approved job-role details to the learning management system (LMS) training assignment process
- [ ] Set up auditable record retention for position-description versions, approvals (sign-offs), and evidence that training assignments were given and completed.

