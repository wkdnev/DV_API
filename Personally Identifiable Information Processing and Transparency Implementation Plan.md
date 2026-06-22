### PT-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has clear, written rules for how it handles people’s personal information, and how it explains those rules to others. It also ensures that everyone who needs to follow the rules knows what to do. Without this, different teams may handle personal information in different ways, miss legal obligations, or fail to respond properly when circumstances change—raising the risk of complaints, regulatory action, and harm to individuals.

The organisation must create and document a policy at organisation level or business-process level that covers: why personal information is processed, what it covers, who is responsible for what, leadership commitment, how different parts of the organisation work together, and how the organisation will meet compliance requirements. This policy must also align with all relevant laws and internal guidance.

A Privacy Officer must be formally appointed to develop, maintain, and share the policy and supporting procedures with the Privacy Officer, Chief Information Security Officer (CISO), information system owners, data stewards, and Legal and Compliance. The procedures must also be shared with Security Operations.

The policy must be reviewed and updated at least every year, and also after material audit findings, confirmed breaches, major system changes or changes to data flows, or changes to relevant requirements. The supporting procedures must be reviewed and updated on the same schedule and when the same triggers occur.

##### Governed PII processing & transparency policy pack with trigger reviews

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Appoint and document the named Privacy Officer (policy/procedure owner) and confirm governance roles (CISO, Legal/Compliance, IS Owners/Data Stewards, Security Operations) | Compliance Manager | Enterprise | 8h | — |
| Produce the organisation-level PII processing & transparency policy pack (single source of truth): purpose, scope, roles/responsibilities, coordination model (privacy↔security), compliance approach, legal/regulatory alignment, and required references | Data Protection Officer | Enterprise | 40h | — |
| Develop the procedure suite that operationalises the policy (role-based execution steps for Privacy Officer, CISO, IS Owners, Data Stewards, Security Operations, Legal/Compliance) including dissemination/acknowledgement steps | Security Engineer | Enterprise | 48h | — |
| Define trigger-based review/update criteria and the annual review cadence for both policy and procedures (including documented triggers: audit findings, confirmed breach, legal/regulatory changes, major system/data-flow changes) | Compliance Manager | Enterprise | 16h | — |
| Implement governance and change control in a document management system: versioning, approval workflow (Privacy Officer + CISO + Legal/Compliance), input capture from IS Owners/Data Stewards, and audit trail requirements | Operations Lead | Enterprise | 32h | £3,000 |
| Create dissemination lists and execute initial dissemination to defined roles (policy vs procedures), including distribution logs/acknowledgements and evidence retention requirements | Project Manager | Enterprise | 16h | — |
| Establish audit-ready evidence pack and maintenance routine: retention of latest approved versions, change logs, dissemination records, and a scheduled review calendar with trigger intake and escalation | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 184h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Appoint a Privacy Officer to be responsible for managing the processing of personal information and the transparency policy and procedures.
- [ ] Draft and get approval for an organisation-wide policy on personal data (PII) processing and transparency. The policy should clearly set out its scope, responsibilities, coordination arrangements, how compliance will be handled, and how it aligns with legal requirements.
- [ ] Create a set of procedures that puts the policy into practice and assigns clear, role-based actions for the Privacy Officer, Chief Information Security Officer (CISO), Information System Owners, Data Stewards, Security Operations, and Legal/Compliance.
- [ ] Publish the policy and procedures in a version-controlled repository and share them with the named policy and procedure roles, keeping records of when they were acknowledged or distributed so the activity can be audited.
- [ ] Set up a governance process for changes to policies and procedures. These changes must be reviewed by the Privacy Officer, the Chief Information Security Officer (CISO), and Legal/Compliance, with input from the system and data owners.
- [ ] Set a review schedule and define when out-of-cycle updates are required (for example, audit findings, confirmed security breach, legal or regulatory changes, and major system or data-flow changes) for both the policy and the procedures.
- [ ] Keep audit-ready records showing who approved the information, how it was shared, and the results of the most recent annual review.


---

### PT-2 — Authority to Process Personally Identifiable Information (Control)

This requirement ensures the organisation only uses people’s personal information for specific, clearly approved reasons, and that it can prove those reasons. Without this, staff may use personal details for the wrong purpose, share them with the wrong organisations, or keep and delete them in ways that breach privacy rules and contractual obligations—creating legal risk and real harm to individuals.

To meet this expectation, for every system that handles personal information, the organisation must identify, document, and keep up to date:
- the approved privacy notice for that system, and
- the official record that authorises what the system is allowed to do with the information, including collecting, using, storing, maintaining, sharing, disclosing, and disposing of it for operational and compliance purposes.

The organisation must also limit everyday use of the information to only the specific purposes stated in these documents and any approved contracts or information-sharing agreements. Finally, it must ensure staff are trained, monitored, and checked so unauthorised use is detected and corrected.

##### PII authority register and purpose-restricted processing enforcement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Build the PII Processing Authority Register (system-to-authority mapping) including privacy notice/SORN references and approved contracts/information-sharing agreements | Compliance Manager | Enterprise | 40h | — |
| Define and document authorised processing scope per system (permitted PII lifecycle operations + authorised purposes) using a structured template and controlled vocabulary | Data Protection Officer | Enterprise | 56h | — |
| Implement purpose tagging model across workflows (normalise purposes, enforce purpose selection on processing/export/share events, and persist purpose tags with requests/transactions) | Software Lead | Enterprise | 120h | — |
| Implement purpose-aware access control and export/disclosure enforcement (role-to-purpose mapping or ABAC, deny-by-default for unauthorised purposes, enforce approved destination/recipient references) | Security Engineer | Enterprise | 140h | — |
| Configure audit logging and evidence capture (purpose tag, requester identity, system, dataset, operation type, destination/recipient where applicable) and integrate with SIEM/monitoring pipelines | DevOps Lead | Enterprise | 72h | — |
| Implement monitoring, alerting, and response workflow for missing/invalid purpose tags and out-of-scope processing attempts (including triage evidence and escalation triggers) | Operations Lead | Enterprise | 56h | — |
| Deliver training and change management package (authorised purposes, what constitutes unauthorised processing, escalation/response steps) and run initial training sessions for application users/admins | Compliance Manager | Enterprise | 32h | — |
| Establish authority change propagation (versioning, change triggers from privacy notice/SORN/contract updates to purpose mappings and enforcement configuration; periodic review cadence) | Project Manager | Enterprise | 48h | — |

**Total Estimated Effort:** 564h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create and keep up to date a register of personal information (PII) processing authorities that links each system that processes personal information to the approved privacy notice or system of records notice (SORN), and to any approved contracts or information-sharing agreements.
- [ ] Define a controlled list of authorised purposes and record, for each system, which personal information (PII) handling actions are permitted in the register.
- [ ] Add purpose tags to every personal data (PII) activity in the application workflow, including access, exporting, sharing, transforming, and generating reports.
- [ ] Use the register as the single source of truth to control who can access and share information, limiting access to the specific purpose for which it is authorised, at the application and data layer.
- [ ] Set up audit logs to record, for every personal data (PII) processing event: the identity involved, the system used, the personal data (PII) dataset, the purpose tag, the type of operation, and the destination or recipient.
- [ ] Set up monitoring rules to alert when a purpose tag is missing or invalid, or when processing happens outside the authorised scope. Send these alerts to the privacy and security review process.
- [ ] Set up a change-management trigger so that when privacy notices, service of notices (SORNs), or contracts are updated, the system automatically updates the purpose mappings and the enforcement settings.


---

#### PT-2.1 — Data Tagging (Enhancement)

This requirement ensures that sensitive personal information has clear instructions on what it is allowed to be used for. Without this, staff or systems could accidentally collect, store, process, share, or delete people’s details in ways that were not approved. This increases the risk of privacy breaches, misuse, and regulatory issues.

To meet this expectation, the organisation must define and document tagging rules for specific types of personal data (such as names, contact details, government identifiers, biometric data, and protected health information). For each type, the tag must state the only permitted actions: collection, storage, processing, sharing, and deletion. These actions must be limited to what has been authorised for Confidential and Secret data.

The organisation must also:
- assign named responsibilities
- provide practical ways for staff to apply the tags
- monitor that tags are in place and being followed, keeping evidence such as extracts of tagged data

In addition, the organisation must maintain a privacy plan and related records, link the tagging rules to the organisation’s approval decisions, and investigate and correct any cases where tagged information is handled outside the permitted scope.

##### Apply authorisation-bound data tags to required PII elements

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and version the data tag schema (PII element type + authorised processing set + Confidential/Secret scope) and produce policy-as-code artefacts with traceability to authorisation decisions | Data Protection Officer / Privacy Lead | Enterprise | 40h | — |
| Implement tag taxonomy registry and configuration management (tag versioning, environment promotion, approval linkage, and rollback strategy) | Compliance Manager | Enterprise | 24h | — |
| Instrument ingestion/entry points (UI, API, batch import, ETL/stream) to detect PII element types and attach/persist the correct tag metadata at data entry | Software Lead | Business Unit | 72h | — |
| Implement tag propagation through transformations and storage layers (ETL/stream processing, object/column mapping, metadata carriage, and persistence validation) | Platform Engineer | Department | 56h | — |
| Build enforcement controls for each action type (collection, storage, processing, sharing, deletion) using tag-driven authorisation checks, including quarantine/deny and approval workflow hooks | Security Engineer | Department | 80h | — |
| Implement audit evidence generation (scheduled verification, audit-ready extracts showing PII elements alongside tags, and SIEM/log event correlation per environment) | Cyber Security Lead | Enterprise | 48h | £6,000 |
| Execute end-to-end testing and evidence pack for acceptance criteria (unit/integration tests, negative tests for unauthorised actions, and production + one non-production validation) | Quality Assurance Lead | Business Unit | 64h | £3,000 |
| Release, operationalise, and document runbooks (monitoring dashboards, alerting on tag violations, incident handling for quarantine, and change-management guidance) | Operations Lead | Department | 32h | — |

**Total Estimated Effort:** 416h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Create a versioned tagging system for each type of personal data (name, contact details, government identifiers, biometric data, and protected health information). Limit authorised processing to collecting, storing, processing, sharing, and deleting that data for information classified as **Confidential** or **Secret**.
- [ ] Match each tag to the organisation’s approval decision for authorisations marked “Confidential” or “Secret”, and record the traceability reference.
- [ ] Set up data ingestion from the user interface (UI), application programming interface (API), batch processing, and extract, transform, load (ETL) to detect personal data (PII) fields and add the correct tag information when writing the data.
- [ ] Ensure tag information is carried through any data transformations and is saved together with the data when stored at rest.
- [ ] Use tags to control enforcement for collecting, storing, processing, sharing, and deleting data. If the tag coverage is missing or incorrect, block the action or send it for approval or quarantine.
- [ ] Add automated checks to confirm that stored personal data (PII) has the required tags and that the tags are correct. Also produce audit-ready extracts that list each PII element alongside its corresponding tag.


---

#### PT-2.2 — Automation (Enhancement)

This requirement is about using smart, automated checks to ensure people handle personal information only in approved ways, and to quickly detect any misuse. Without these checks, staff could accidentally (or improperly) view, change, or share personal details they are not authorised to use, or the organisation could process that information in ways that breach its privacy commitments—leading to legal, reputational, and financial harm.

To meet this expectation, the organisation must clearly set out how authorised handling of personal information will be enforced through automated rules. This includes:
- automatically recognising and labelling personal data
- automatically allowing or blocking access based on approved permissions
- continuously monitoring activity to spot mismatches

If non-approved behaviour is detected, the system must raise alerts. The organisation must also be able to demonstrate that these automated actions follow the documented authorisation decisions, including:
- named responsible people
- up-to-date privacy and processing documentation
- evidence that alerts are investigated and acted on

##### Automated PII enforcement via policy-based access, tagging, and alerts

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define machine-enforceable PII authorisation policy-as-code (purposes, roles, allowed operations, blocked scenarios; include rule IDs/versions and deny-by-default semantics) | Compliance Manager | Enterprise | 24h | — |
| Select/confirm PII tagging approach and implement tagging integration (ingestion and/or query-time), including persistence strategy for tags/metadata and mapping to policy categories | Security Engineer | Enterprise | 40h | £25,000 |
| Implement policy enforcement at point of access (API/data access integration, field/record-level decisions where supported, allow/deny decision plumbing, deny when authorisation cannot be validated) | Security Engineer | Enterprise | 56h | £10,000 |
| Instrument audit logging for all PII-relevant operations (identity, request context/purpose, PII tag/category, operation type, decision outcome, policy rule ID/version, evidence fields) and ensure retention/immutability alignment | Operations Lead | Enterprise | 24h | £8,000 |
| Configure continuous monitoring and automated alerts for defined deviation scenarios (unauthorised export, purpose mismatch, repeated denied attempts, untagged/unknown PII access), including routing and alert payload schema | Service Delivery Manager | Enterprise | 24h | £6,000 |
| Maintain auditable linkage between enforcement and authorisation (store decision basis references in audit trail; implement policy version traceability and change control hooks) | Data Protection Officer | Enterprise | 16h | — |
| Test, validate, and produce evidence pack (authorised/unauthorised test cases, sample audit/alert records, enforcement coverage metrics, runbook for SOC triage) | Quality Assurance Lead | Enterprise | 32h | — |

| Total Estimated Effort | 216h |  |
|---|---:|---:|
| Total Estimated Cost |  | £49,000 |

###### Actions Required for Compliance

- [ ] Define machine-enforced rules for processing authorised personal data (role and purpose → which actions are allowed), using a “deny by default” approach, as policy-as-code.
- [ ] Set up automated personal data (PII) tagging and classification when data is first brought in and/or when it is searched, and carry those tags through to the enforcement layer so they can be applied consistently.
- [ ] Add a policy decision step into the application programming interface (API) and data access routes to enforce “allow” or “deny” rules for each personal identifiable information (PII) tag and each operation.
- [ ] Set up and centralise audit logs for all actions that involve personal data (PII), recording who did it, the situation/context, the relevant PII tag or category, the applicable policy rule identifier and version, and the final decision/outcome.
- [ ] Set up continuous monitoring to detect defined deviations (for example, unauthorised data export, using the data for the wrong purpose, or repeated denied access attempts) and automatically send alerts when they occur.
- [ ] Set up an alert triage process that collects the required supporting evidence, and send each alert to the responsible security operations centre (SOC) or application security queue.
- [ ] Run automated test cases using both authorised and unauthorised identities to confirm the expected enforcement results and that alerts are correct.


---

### PT-3 — Personally Identifiable Information Processing Purposes (Control)

This expectation is about making sure the organisation is clear about why it collects and uses people’s personal information, and that it uses that information only for those stated reasons. If it does not, personal data could be used for the wrong purpose, shared or kept for longer than intended, or altered in ways that surprise people—leading to legal, reputational, and financial harm.

The organisation must identify and document the specific purposes for using personal information, including identity checks, eligibility decisions, benefits administration, security monitoring, and incident response. It must explain these purposes in its public privacy notices and in its internal policies.

The organisation must also ensure that every step of handling personal information—from collecting it, using it, storing it, sharing it, maintaining it, and finally disposing of it—matches the documented purposes.

Finally, the organisation must monitor for changes in how personal information is processed. If new or changed purposes are introduced, it must update its privacy assessments and records, obtain legal agreement, submit the change for formal approval by the senior privacy lead, and only then update the public notices and related records.

##### PII purpose register with enforced purpose-scoped access and change approvals

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design the PII Processing Purposes Register data model (purposes, PII data elements, life-cycle coverage, system/process mapping, purpose IDs, owners, review cadence, evidence links) and define required fields/controls for versioning and audit traceability | Compliance Manager | Enterprise | 24h | — |
| Build the register as a controlled, version-controlled system of record (e.g., within existing GRC/wiki tooling) including purpose-ID governance, change history, approval workflow hooks, and exportable purpose text for notices | Project Manager | Enterprise | 56h | £6,000 |
| Implement purpose-scoped access enforcement (ABAC/purpose context propagation, authorisation checks for PII access/export/disclosure, deny-by-default for mismatched purposes, exception workflow with approvals) across application/API/data access layers | Security Engineer | Enterprise | 120h | £18,000 |
| Implement purpose-tagging and data-flow controls (PII field/record tagging, API response filtering, data lake/messaging export restrictions, and purpose context validation at ingestion and egress) | Platform Engineer | Enterprise | 96h | £12,000 |
| Configure retention/disposal alignment with purposes (lifecycle rules per purpose, including backups/replicas intent, deletion/obfuscation verification jobs, and evidence generation for audit) | Operations Lead | Enterprise | 72h | £5,000 |
| Integrate monitoring/auditing for purpose drift (SIEM detections for PII access outside approved purpose context, unusual query/export patterns, retention anomalies; dashboards and quarterly sampling reports) | DevOps Lead | Enterprise | 64h | £10,000 |
| Establish privacy compatibility review workflow for purpose changes (legal concurrence capture, senior privacy approval gates, evidence pack generation, and synchronised updates to register and privacy notices before release) | Data Protection Officer | Enterprise | 40h | — |
| Deliver privacy notice and internal documentation synchronisation (controlled content workflow, traceability from register purpose IDs to public notice wording and internal privacy documentation; regression checks before go-live) | Compliance Manager | Enterprise | 48h | £3,000 |

**Total Estimated Effort:** 520h  
**Total Estimated Cost:** £54,000

###### Actions Required for Compliance

- [ ] Create and keep a version-controlled register of personal information processing purposes covering all five purposes and the full life cycle of the personal information.
- [ ] Set up a controlled process to publish the same “purpose text” consistently in public privacy notices and internal privacy documents.
- [ ] Add purpose identifiers (tags or attributes) to requests to access personal data (PII) and to requests describing how that data will move, and enforce authorisation based on the stated purpose (deny the request or require approval when the purpose does not match).
- [ ] Set retention and disposal rules so that the full lifecycle of personal data (including the intended retention of backups and replicas) matches the documented reasons for processing.
- [ ] Link application logs to a security information and event management (SIEM) system to spot and alert on any access, export, or sharing of personal data (PII) outside the approved purposes.
- [ ] Set up a documented change process that checks whether the change still meets privacy requirements, gets agreement from the legal team, and routes the update for approval by a senior privacy lead before updating notices or records.


---

#### PT-3.1 — Data Tagging (Enhancement)

This requirement is about making sure that sensitive personal information has a clear label explaining why it is allowed to be used. Without these labels, the organisation could accidentally use people’s details for the wrong purpose, fail to meet legal and contractual obligations, or lose track of how information is handled as it moves between systems. This increases the risk of misuse, non-compliance, and privacy harm.

To meet this expectation, the organisation must:
- identify which information fields are in scope, including direct identifiers (name and social security number), contact details (email and phone), and protected health information;
- define a standard set of allowed purpose labels;
- document how the labels are used and keep a clear structure for them;
- ensure the labels remain attached to the information as it moves through the system, so that anyone reviewing a change can confirm it matches the documented purposes.

The organisation must also include this approach in its privacy plan, assign named responsibilities for applying the labels and providing transparency, and keep evidence (for example, data extracts) showing the tagged fields together with their purpose labels.

##### Purpose-tagging for in-scope PII fields across data flows

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define canonical purpose-tag model (enumerated allowed purpose values) with versioning (e.g., `purposeTag.v1`) and governance workflow for changes | Data Protection Officer / Privacy Lead | Enterprise | 24h | — |
| Define in-scope PII element mapping (PT-03.01 ODP.02) and bind each element to allowed purpose values (field-level mapping + schema binding rules) | Data Protection Officer / Privacy Lead | Enterprise | 32h | — |
| Implement purpose-tag schema and storage/event contract (canonical representation in database records and emitted with API responses/events/messages) | System Design Authority | Enterprise | 56h | — |
| Implement ingestion enforcement (fail-closed validation) at source for all entry points (API/ETL/UI), including remediation routing for controlled exceptions | Software Lead | Business Unit | 72h | — |
| Implement tag preservation through transformations (normalisation/enrichment/tokenisation/projection) and deterministic merge/copy rules across services and data pipelines | Platform Engineer | Business Unit | 64h | — |
| Update observability and audit evidence generation (auditable extracts showing tagged PII fields + purpose tags across environments; evidence retention approach) | Compliance Manager | Enterprise | 40h | — |
| Testing & assurance: unit/integration tests for tag propagation, negative tests for invalid/missing purposes, and security/compliance validation of evidence extracts | Quality Assurance Lead | Department | 48h | — |

**Total Estimated Effort:** 376h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] List and assign version numbers to the permitted “processing purpose” values from `pt-03.01_odp.01`.
- [ ] Create a field-by-field mapping for all in-scope personal data (PII) elements from `pt-03.01_odp.02`.
- [ ] Set up a purpose-tag structure that links every in-scope personal data (PII) field to the permitted purpose values.
- [ ] Ensure that, when data is first received, the system only allows purpose tags to be added for all in-scope personal data (PII) fields, and blocks the data if the purpose tags cannot be set (fail-closed).
- [ ] Update all data transformations and all event, application programming interface (API), and messaging payloads so the purpose-tag metadata is kept with the data.
- [ ] Create and keep audit-ready records that show which tagged personal data fields (PII) are used, and the purpose tags linked to each field.


---

#### PT-3.2 — Automation (Enhancement)

This requirement is about automatically keeping an accurate, up-to-date record of where personal information is stored in your internal systems, and the reason it is allowed to be used. Without this, the organisation could lose track of which datasets contain people’s details, record an incorrect reason for using them, or be unable to show regulators and customers that personal information is handled openly and only for approved purposes.

To meet this expectation, the organisation must use automated tools to scan its internal data catalogue, automatically identify any items that contain personal information, and then automatically link each identified item to the authorised purpose for processing it, using the organisation’s own rules for matching purposes to policies. The organisation must be able to produce evidence exports showing the personal-information identifiers and the linked purposes, maintain a privacy plan and supporting documents explaining how the purposes are handled, and ensure that the right people are responsible for oversight and enforcement based on these automated records.

##### Automate PII purpose tracking via catalogue discovery and mapping

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define PII purpose taxonomy and purpose-to-policy mapping rules (policy-as-code where feasible), including rule versioning scheme and “as-of” semantics | Data Protection Officer | Enterprise | 40h | — |
| Implement catalogue schema extensions for persisted PII tags and processing purpose attributes (dataset/table + column/field granularity), including lineage/asset identifiers and audit fields | System Design Authority | Enterprise | 24h | — |
| Configure automated discovery jobs to scan catalogue-connected on-prem sources and emit deterministic/profiling-based PII signals; include scheduling, change-event triggers, and operational runbooks | Platform Engineer | Enterprise | 56h | £18,000 |
| Implement automated PII classification and metadata tagging pipeline to persist tags back into the catalogue with confidence thresholds and deterministic naming rules | Security Engineer | Enterprise | 40h | £6,000 |
| Implement automated purpose mapping engine to translate PII tags/signals into processing purpose(s) using mapping rules; include rule evaluation traceability and “as-of” timestamp | Software Lead | Enterprise | 48h | £12,000 |
| Build re-tagging and re-mapping triggers for schema/ETL output changes and source ownership changes, with idempotency and rollback/consistency controls | DevOps Lead | Enterprise | 32h | — |
| Develop auditable evidence export capability (on-demand and scheduled) producing snapshot exports with asset identifiers, PII tags, mapped processing purpose(s), mapping rule version, and as-of time; include access controls for export | Compliance Manager | Enterprise | 24h | — |
| Integrate enforcement hooks so downstream consumers can retrieve processing purpose attributes (API/connector/events) and validate purpose alignment for relevant workflows | Operations Lead | Enterprise | 24h | £8,000 |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £44,000

###### Actions Required for Compliance

- [ ] Choose and set up an approved on-premises data catalogue to act as the official source of record for whether personal data (PII) is present and what it is used for.
- [ ] Define a “purpose taxonomy” and put in place rules that link each personal data (PII) tag to the processing purposes that are authorised.
- [ ] Set up automated discovery jobs that run on a schedule and also when changes are detected, for every on-premises source listed in the catalogue.
- [ ] Set up automated personal data (PII) identification and store the personal data (PII) labels in the data catalogue at the dataset or table level and/or at the column or field level.
- [ ] Set up automated purpose mapping to fill in a “processing purpose” field for every asset that contains personal data (PII), including the rule version and the date and time the mapping was last updated.
- [ ] Create automated evidence export reports that include asset identifiers, personal data (PII) tags, the mapped purposes, the mapping rule version, and the snapshot time.
- [ ] Where needed, link the catalogue’s purpose information to the systems that enforce it downstream (for example, access governance, data loss prevention, and workflow approval tools).


---

### PT-4 — Consent (Control)

This requirement is about making sure people are clearly and personally asked for permission before their information is collected and used. Without a proper consent process, people may agree without realising what is happening, or may not be able to change their mind later. This creates risks for both the organisation and the individual, including legal, reputational, and personal harm.

To meet this expectation, the organisation must provide a privacy notice consent portal that:
- shows the privacy notice before anyone can agree
- uses clear opt-in checkboxes that the person must actively select
- explains in plain language what the person is agreeing to

Before consent is accepted, each person must be identified (for example using their Common Access Card/Personal Identity Verification (CAC/PIV) or an equivalent method). The organisation must also keep electronic records showing what was agreed and the date and time.

The portal must allow individuals to withdraw consent online, again after identity verification, and must record that withdrawal.

The organisation must document how it handles consent, keep the relevant records, and assign clear responsibilities for running the process.

##### Identity-verified opt-in consent portal with revocation enforcement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define consent model and data contract (opt-in purposes/scopes, privacy notice versioning, evidence schema, consent state machine incl. revoked) | Compliance Manager | Enterprise | 16h | — |
| Design and implement identity-verified consent portal UX (privacy notice first in plain language; opt-in checkboxes; no pre-selection; consent submission blocked until successful CAC/PIV auth) | Software Lead | Business Unit | 40h | — |
| Implement CAC/PIV (or equivalent) integration with enterprise IdP for portal authentication and identity assurance capture | Security Engineer | Enterprise | 32h | — |
| Build consent evidence persistence (append-only storage of consent and revocation events: user identifier, assurance level, purposes, timestamps, privacy notice version) | Platform Engineer | Department | 32h | — |
| Implement revocation workflow (identity re-check, display prior consents incl. notice version/purposes, record revocation evidence, update consent state) | Software Lead | Department | 24h | — |
| Enforce consent-before-collection in downstream services (consent-status API/claims token, gating logic per purpose, fail-closed behaviour, integration tests) | DevOps Lead | Business Unit | 48h | — |
| Establish auditability and retention controls (SIEM/monitoring hooks, immutable audit trail, retention configuration, evidence export for assurance) | Operations Lead | Enterprise | 24h | £12,000 |
| Security, privacy, and assurance testing (test plan, UAT scripts, negative tests for bypass attempts, accessibility/plain-language checks, audit evidence validation) | Quality Assurance Lead | Department | 24h | — |

**Total Estimated Effort:** 260h  
**Total Estimated Cost:** £12,000

###### Actions Required for Compliance

- [ ] Design the consent portal so that it shows the privacy notice in plain language before any choice to opt in is recorded.
- [ ] Use Common Access Card (CAC) / Personal Identity Verification (PIV) (or an equivalent method) to verify identity through the organisation’s identity provider (IdP). Do not allow consent submissions if authentication fails.
- [ ] Create a consent record store and an append-only audit log that records the consent purpose(s), the date and time, the user identifier, the identity assurance level, and the privacy notice version.
- [ ] Set up an electronic process to revoke access that first verifies the person’s identity, keeps a record of the proof for the revocation, and updates the consent status.
- [ ] Add checks for consent status to every way personal data is collected or processed, so that data collection for approved purposes is stopped when consent is missing or has been withdrawn.
- [ ] Check and record how evidence is produced by running end-to-end tests for consent, enforcing “consent before collection”, and revoking consent.


---

#### PT-4.1 — Tailored Consent (Enhancement)

This expectation is about giving people genuine, detailed control over how your organisation uses their personal information, rather than making one standard decision for everyone. Without this, the organisation might use certain information in ways the person did not agree to, which increases privacy risk and could damage trust—leading people to stop using the service.

To meet this, the organisation must provide an easy-to-use consent dashboard. Individuals should be able to turn permission on or off for specific types of personal information, with clear explanations of what each option means. The organisation must then follow those choices consistently, including using different rules depending on staff roles, and using its internal rules to allow or block processing as appropriate.

Whenever a person changes a setting, the organisation must record the change, including who made it, what was changed, what the new decision is, and the date and time. This makes the outcome clear and able to be checked later.

##### Granular consent dashboard with policy-engine enforcement and audit logs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define controlled catalogue of PII elements and mapping to processing actions/purposes (pt-04.01_odp mechanisms), including plain-language toggle wording and versioned mapping document | Compliance Manager | Enterprise | 24h | — |
| Design and implement consent data model (per user, per PII element, optional per purpose) with schema versioning and migration strategy | System Design Authority | Enterprise | 40h | — |
| Build user-facing consent dashboard (authenticated UI) with granular ON/OFF toggles, validation, and consent state retrieval/update flows | Software Lead | Enterprise | 56h | — |
| Implement policy-engine enforcement (policy-as-code) for role-aware allow/deny decisions, including integration points for processing requests and consistent decision API | Security Engineer | Enterprise | 72h | £15,000 |
| Integrate consent enforcement into application processing (withhold/mask/substitute behaviour, downstream dependency handling, and safe defaults when consent is missing/unknown) | Platform Engineer | Enterprise | 64h | — |
| Implement immutable audit logging for every consent change (before/after state, actor identity/system, timestamps, affected elements) and forward to SIEM with retention alignment | Operations Lead | Enterprise | 48h | £8,000 |
| End-to-end testing and audit readiness (test cases for toggle changes, enforcement outcomes, role scenarios, audit evidence completeness; produce release evidence pack) | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 384h  
**Total Estimated Cost:** £23,000

###### Actions Required for Compliance

- [ ] Create a controlled list (catalogue) of application personal data (PII) elements and link each element to the specific reasons for processing and the actions taken.
- [ ] Create a consent data model that records, for each user and each personal data (PII) element, whether consent is ON or OFF, and includes version history.
- [ ] Develop an authenticated consent dashboard with detailed on/off switches and clear, plain-language explanations for each personal information (PII) item.
- [ ] Set up policy rules that check each processing request using the current consent status and the requester’s role information.
- [ ] Set up enforcement controls so that any output or later processing does not show personal data (PII): it must be withheld, masked, or replaced.
- [ ] Set up tamper-resistant audit logs for every consent change, recording who made the change, when it happened, what was affected, and what the values were before and after. Then send these records to security information and event management (SIEM).


---

#### PT-4.2 — Just-in-time Consent (Enhancement)

This requirement is about asking people for permission at the right time—exactly when their personal information is about to be used—and again if the reason for using it changes or if the use becomes more sensitive. Without this, an organisation could use people’s data in ways they did not expect, or increase privacy risk—for example by sharing it with partners, using automated profiling to make decisions, or accessing highly sensitive information—leaving people unable to make an informed choice.

To meet this expectation, the organisation must provide:
- a clear consent prompt on its website,
- a privacy preference place where people can manage their choices, and
- a timely on-screen notification that explains what is about to happen and lets people choose to opt in or opt out at the first relevant moment.

It must repeat these choices whenever the purpose changes or the privacy risk increases. This must be done specifically when sharing with third parties, when using profiling or automated decisions, or when accessing sensitive “Secret” information is involved.

##### Event-driven consent gate with just-in-time prompts and enforcement

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define processing event taxonomy and emission contracts (first relevant processing, purpose change, privacy risk level change, third-party sharing, profiling/automated decision-making, Secret data access) including schema/versioning | System Design Authority | Enterprise | 24h | — |
| Implement consent policy mapping (policy-as-code) covering pt-04.02_odp.03 processing types and enforcement actions (block/allow with opt-in/opt-out rules) with testable acceptance criteria | Compliance Manager | Enterprise | 20h | — |
| Design and implement the event-driven consent gate enforcement point (API gateway plugin / middleware / orchestration) to evaluate entitlements, determine when just-in-time prompts are required, and return enforceable decisions/tokens | Software Lead | Enterprise | 56h | — |
| Build consent entitlements service: decision persistence model (timestamps, event type, purpose/risk context, individual ID), token/entitlement issuance, and propagation strategy for preference centre updates | Platform Engineer | Enterprise | 40h | — |
| Implement audit logging and evidence pipeline (gate-required events, presented mechanisms, recorded choice, allow/block outcome) integrated with SIEM/observability with retention alignment | Security Engineer | Enterprise | 24h | — |
| Develop UI/UX integration: web portal consent prompt (opt-in/opt-out), just-in-time notification with deep link to privacy preference centre, and preference centre flows that update the same entitlements used by the gate | Quality Assurance Lead | Enterprise | 32h | — |
| Add downstream enforcement hooks for third-party sharing, profiling/automated decision-making, and Secret data access (gate call/entitlement validation before execution) plus end-to-end integration tests | DevOps Lead | Enterprise | 48h | — |
| Conduct security/compliance validation: abuse/bypass testing, negative tests for event tampering, propagation window verification, and audit evidence review against PT-4(2) expectations | Cyber Security Lead | Enterprise | 24h | £6,000 |

| Total Estimated Effort |  |  | **268h** |  |
| Total Estimated Cost |  |  |  | **£6,000** |

###### Actions Required for Compliance

- [ ] Define and implement a set of categories for processing events, covering: first processing, changes in purpose, changes in risk, sharing with third parties, profiling and automated decision-making, and access to Secret data.
- [ ] Set up a “policy as code” consent mapping to decide when consent is needed and what enforcement action should be taken for each type of event.
- [ ] Set up an authoritative consent check “gate” (for example, an application programming interface (API) gateway, middleware, or orchestration layer) that stops processing requests before they are carried out by downstream systems.
- [ ] Integrate web portal prompts that let people choose whether to receive communications (opt in or opt out), send notifications only when they are needed (just in time), and provide a privacy preferences centre—using the same consent permissions for all three.
- [ ] Store consent decisions with the date and time they were made, along with the related event details, and record audit logs showing how prompts and notifications were shown and handled, including the final allow or block outcome.
- [ ] Update downstream services that share data with third parties, use profiling or automated decision-making, or access Secret data so they must first check and confirm consent before they run.


---

#### PT-4.3 — Revocation (Enhancement)

This requirement is about making it easy for people to withdraw permission for how their personal information is used. If withdrawing consent is difficult to find, confusing, or not properly checked, people may not be able to change their minds when their circumstances change. In that case, the organisation could keep using their information even though it no longer has valid permission.

To meet this expectation, the organisation must provide:
- a self-service consent withdrawal portal, and
- an authenticated ticket process

These must allow individuals to submit a consent withdrawal request, confirm they are the correct person before the request is accepted, and then track the request’s progress and result.

The organisation must treat these requests as consent withdrawals under its own consent withdrawal policies and procedures, follow the agreed design and user experience approach, and ensure the process matches its privacy plan and its transparency and information-handling procedures.

The organisation must also clearly assign named responsibilities for the portal, the user experience, and the privacy and information-handling parts of the process, and keep records showing how the withdrawal approach, policies, and user experience are implemented.

##### Authenticated self-service consent revocation portal with ticket workflow

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define revocation scope model and purpose-to-consent mapping (full vs partial), including policy/procedure alignment and exception handling | Compliance Manager | Enterprise | 24h | — |
| Design authenticated self-service portal UX and data capture requirements (guided flow, consent purpose selection, identity assurance outcome capture, status view) | Project Manager | Enterprise | 32h | — |
| Implement portal integration with enterprise identity service including step-up where appropriate, and enforce authenticated session handling | IAM Lead | Enterprise | 40h | — |
| Configure and implement ticket/case creation workflow in the case-management system (fields, validation, assignment/approvals, lifecycle states, SLA timers) | Service Delivery Manager | Enterprise | 40h | £6,000 |
| Build workflow orchestration to locate affected consent record(s)/processing purposes for the authenticated subject and trigger revocation actions in the consent management layer (or downstream systems) | Platform Engineer | Enterprise | 56h | £12,000 |
| Implement audit-ready logging and evidence retention (portal access, authentication result, ticket lifecycle events, consent records affected, workflow actions, final outcome) with SIEM integration | Security Engineer | Enterprise | 40h | £8,000 |
| Operational readiness: runbooks, named responsibilities, monitoring/alerting, and end-to-end testing (including audit evidence verification) | Operations Lead | Enterprise | 32h | — |
| User acceptance testing, security testing support (incl. auth/session, authorisation, tamper resistance), and go-live readiness sign-off | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £26,000

###### Actions Required for Compliance

- [ ] Design and build the self-service consent withdrawal portal flow, following the agreed user experience and user interface (UX/UI) approach
- [ ] Integrate the portal with the organisation’s identity system so users must be authenticated (and complete extra verification when required) before the system accepts any certificate revocation requests.
- [ ] Set up ticket or case creation in the organisation’s case-management system, with the form fields linked to the consent record(s) and the processing purpose(s).
- [ ] Set up workflow steps to: check the person’s identity, find the correct consent records, cancel consent according to the consent cancellation policies and procedures, and log the results.
- [ ] Add secure status tracking for individuals linked to the ticket reference and the ticket’s workflow stages
- [ ] Enable audit logs for portal access, authentication results, ticket status changes, consent records that were affected, and the final processing outcome.
- [ ] Document and assign named responsibilities for operating the portal, managing workflows, and making decisions about privacy and how information is handled.


---

### PT-5 — Privacy Notice (Control)

This requirement is about making sure people are clearly told, from the very first time they deal with your organisation, how their personal information will be used. If this is not done, people may be surprised by how their details are handled, shared, or used for reasons they did not expect. This can lead to loss of trust, complaints, and legal or regulatory problems.

To meet this requirement, your organisation must provide an easy-to-understand privacy notice the first time someone interacts with you. You must also make sure the same notice is available at least once every year and whenever the notice changes.

The privacy notice must be written in plain language. It must explain what personal information is processed, name the authority that authorises it, and set out the purposes for using the information. It must also say what choices individuals have (if any) about how their information is used and whether it is shared with other parties.

##### Central privacy notice service with versioned publishing and choice capture

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define privacy notice content model and metadata schema (version, effective date, last reviewed, approval reference) and component structure (authority/legal basis, purposes, sharing/recipients, choices, contact details) | Data Protection Officer | Enterprise | 24h | — |
| Build/implement authoritative version-controlled privacy notice repository (content store with approval workflow hooks and environment segregation) | Platform Engineer | Enterprise | 40h | £6,000 |
| Create plain-language templates and accessibility/readability validation rules (controlled vocabulary, jargon checks, consistency checks) and package for Privacy/Legal review | Compliance Manager | Enterprise | 32h | — |
| Develop privacy notice rendering service (API/web/mobile integration) that selects the correct approved version and serves it before or at first PII collection; include response caching and audit-friendly identifiers | Software Lead | Enterprise | 72h | £18,000 |
| Integrate choice capture mechanism (preference centre/choice engine) so the “choices” section matches configured processing and store evidence of notice version served and selections where applicable | Security Engineer | Enterprise | 56h | £12,000 |
| Implement controlled publishing and change management (only approved versions deploy to production; effective-version switching; automated propagation to rendering service) | Operations Lead | Enterprise | 32h | — |
| Implement annual review and change-triggered update workflow (review scheduling, due-date checks, evidence of review/publish dates, and monitoring/alerting) | Project Manager | Enterprise | 28h | £4,000 |
| End-to-end testing and audit evidence pack (journey mapping for all PII first-collection points, regression tests, logging verification, and readiness for PT-5 evidence requirements) | Quality Assurance Lead | Enterprise | 40h | £3,000 |

**Total Estimated Effort:** 324h  
**Total Estimated Cost:** £43,000

###### Actions Required for Compliance

- [ ] Create an official, version-controlled library of privacy notices, owned by the Privacy and Legal teams, with an approval workflow.
- [ ] Create plain-language notice templates that clearly state who is responsible, what the notices are for, who information may be shared with, and what choices individuals have (or state explicitly that there are no choices).
- [ ] Add a privacy notice display service to every user journey where personal data is first collected, so the privacy notice is shown before the user enters any data or at the first time data is entered.
- [ ] Set up a way to record users’ consent and choices, and make sure the options shown in the notice match how data is actually processed and shared.
- [ ] Use controlled publishing so only approved versions of notices can be shown in the live (production) environment, and make sure updates automatically set the current effective version.
- [ ] Automate the scheduling of annual reviews, and automatically block or flag the notice if it is past its review due date.


---

#### PT-5.1 — Just-in-time Notice (Enhancement)

This requirement is about telling people, at the exact moment they share their personal information, what will happen to that information next. It matters because if organisations wait too long or provide unclear, general information, people may not understand how their data will be used, shared, or handled in ways that could affect their privacy—especially when the next step is higher risk.

To meet this expectation, the organisation must provide a clear privacy notice either:
- when the person gives their personal information, or
- at the same time the organisation takes an action using that information.

For higher-risk actions, the notice must be shown no later than immediately before the higher-risk step starts, and in any case within 5 minutes.

The notice must:
- relate to the specific personal details being used and the specific action being taken,
- be shown where the person can see it during the process, and
- explain how the organisation will use the information, including what it is used for and who it is shared with, where relevant.

The organisation must also:
- document how it will do this,
- assign named staff to make sure it happens,  
- use reliable ways to show the notice, and
- keep evidence showing when the notice was presented.

##### Event-driven just-in-time privacy notices with 5-minute gating

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define higher-risk data action catalogue (data actions, PII categories/fields, higher-risk flags, and PT-5(1) applicability rules) | Compliance Manager | Enterprise | 24h | — |
| Approve notice content/templates and map each notice to data actions and specific PII elements (version-controlled configuration) | Data Protection Officer | Enterprise | 32h | — |
| Design event-driven trigger points and UI placement strategy (inline near relevant fields/action buttons; ensure “reasonably see” requirement) | Software Lead | Business Unit | 24h | — |
| Implement backend event handling and “notice token” gating for higher-risk actions (timestamp validation within 5-minute window; reject/defer logic) | Security Engineer | Department | 56h | — |
| Implement audit evidence capture and retention alignment (template ID/version, first display timestamp, user/session ID, acknowledgement state, action start timestamp; immutable logging) | Cyber Security Lead | Enterprise | 32h | — |
| Build configuration management and release controls for notice mappings/catalogue (traceability, environment promotion, rollback strategy) | Project Manager | Enterprise | 16h | — |
| End-to-end testing and assurance (unit/integration tests for timing, UI visibility checks, negative tests for missing/expired tokens, evidence completeness review) | Quality Assurance Lead | Department | 40h | — |

**Total Estimated Effort:** 224h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define and keep up to date, in a version-controlled catalogue, the list of data actions this application can perform, and identify which of those actions are higher-risk for this application.
- [ ] For each data action, match it to the approved just-in-time notice template (or section) and identify the specific personal information (PII) fields involved.
- [ ] Set up event triggers so the notice is shown when data is collected and again right before the mapped data action starts.
- [ ] Add backend checks for higher-risk actions so they only proceed when a valid “notice displayed” token is provided, and the token’s timestamps fall within the last 5 minutes.
- [ ] Show the notice in the user’s workflow at a place where the person can reasonably see it before continuing
- [ ] Record auditable evidence for every notice instance, including the template identification and version, the time it was shown, the user and session details, the acknowledgement status, and the time the action started.


---

#### PT-5.2 — Privacy Act Statements (Enhancement)

This requirement is about making sure people are clearly told, at the point they are asked for information, why the information is being collected and how it will be used. Without this, individuals may unknowingly share details that are stored and used in ways they did not expect. That can lead to poor decisions, loss of trust, and legal or reputational harm for the organisation.

To meet this requirement, the organisation must identify every way information is collected—such as paper forms, online pages, mobile applications, and telephone scripts—where the information is intended to be kept in a formal Privacy Act record system. For each of these collection points, the organisation must provide a Privacy Act notice either:
- on the same form or within the same request process, or
- on a separate sheet or form the person can keep.

The notice must say:
- the legal basis for requesting the information,
- whether providing the information is required or optional,
- the main purposes for collecting it and any published routine uses,
- what will happen if the person does not provide the information,
- the relevant system of records reference (citation) and a link.

The organisation must also document the process and the named person responsible, and ensure privacy and legal advisers are consulted on the wording.

##### Privacy Act notice templates embedded in all data-collection flows

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce system-of-records mapping for all data-collection endpoints (web, mobile, API intake, downloadable/printable forms, and any agent/telephone scripts), including required system-of-records citation/link and published routine uses | Data Protection Officer | Enterprise | 40h | — |
| Draft PRIVACT statement templates for each mapped system of records, ensuring each template includes authority, mandatory/voluntary, principal purposes, published routine uses, effects of not providing, and system-of-records citation/link | Compliance Manager | Enterprise | 32h | — |
| Legal/privacy review and approval workflow for template wording and routine uses (including versioning and sign-off evidence) | Compliance Manager | Enterprise | 24h | — |
| Implement controlled template library and data model (template versioning, keyed by system-of-records mapping; immutable audit metadata; retrieval API for UI) | Software Lead | Enterprise | 56h | — |
| Embed notices at point of collection across all supported channels (web/mobile UI components, API intake UI/step where applicable, and generation of separate retainable/printable notice where required) | Platform Engineer | Enterprise | 72h | — |
| Add release-time validation gate in CI/CD to block deployment of any collection flow lacking (a) valid system-of-records mapping and (b) complete notice template fields; include automated checks and failure reporting | DevOps Lead | Enterprise | 48h | — |
| Implement audit evidence capture (which template version was shown, embedding location/flow identifier, timestamp, approver reference) and produce an evidence report format for audits | Operations Lead | Enterprise | 32h | — |

| Total Estimated Effort | 304h | Total Estimated Cost | £0 |

###### Actions Required for Compliance

- [ ] Create and keep an up-to-date record that maps every application’s data-collection endpoint to its associated citation or link.
- [ ] Develop Privacy Act statement templates for each mapped system of records, including all required notice elements.
- [ ] Add the correct **PRIVACT** statement to the beginning of every web and mobile data-collection flow (or create a separate notice that can be kept and reused).
- [ ] Set up a release check at the time of deployment that stops the release if the data collection process does not have a valid “system of record” mapping or is missing required notice fields.
- [ ] Get approval from privacy and legal counsel for the wording in templates and for routine uses, and keep a record of the approval evidence.
- [ ] Provide audit evidence showing which template version was used for each deployed data collection flow.


---

### PT-6 — System of Records Notice (Control)

This requirement is about making sure the public is clearly informed, in advance and through the correct official channels, when the organisation holds personal information about people and how it uses that information. Without this, people may not know what information is collected, why it is kept, who it may be shared with, or the legal basis for doing so. This increases the risk of personal data being used unfairly or improperly and can lead to a loss of public trust.

To meet this expectation, the organisation must:
- identify which of its information systems are covered by the Privacy Act
- prepare the required public notice using the government’s guidance
- for any new notice or any notice that is significantly changed, submit it in advance for review to the relevant oversight bodies and the appropriate congressional committees before publishing it in the Federal Register

The organisation must also ensure each notice stays accurate, up to date, and matches what the system actually does.

##### SORN workflow with OMB A-108 template, review gates, and change triggers

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Create/approve an OMB A-108-aligned SORN template and required content mapping (including existence/character, purposes, authority, categories of records and individuals, routine uses, and additional required details) | Data Protection Officer | Enterprise | 24h | — |
| Define “new” vs “significantly modified” SORN triggers and document the change-intake decision logic (including required system-owner selections for trigger outcomes) | Compliance Manager | Enterprise | 16h | — |
| Implement workflow states and review gates (draft → completeness checks → advance review submission → approval → Federal Register publication-ready) with explicit gate criteria and non-bypass rules | Project Manager | Enterprise | 32h | — |
| Build the completeness/consistency checklist and evidence capture requirements (template version, checklist outputs, boundary/data-flow alignment checks, reviewer approvals, submission timestamps, and publication references) | Quality Assurance Lead | Enterprise | 24h | — |
| Configure the advance review process integration (oversight body submission steps, approval routing, and evidence retention for audit) | Compliance Manager | Enterprise | 20h | — |
| Establish periodic review cadence and re-check triggers (scheduled SORN reviews plus re-running completeness checks on system changes that could affect SORN content) | Governance Workflow Owner (GRC/Compliance Lead) | Enterprise | 16h | — |
| Pilot the workflow on the in-scope application: run trigger determination, complete draft, execute gates, submit for advance review, publish, and perform post-publication reconciliation against the approved draft | Privacy Counsel | Enterprise | 40h | — |
| Produce audit pack and training for system owners/records/publishing coordinators (how to use the template, how to respond to checklist findings, and how evidence is retained) | Compliance Manager | Enterprise | 18h | — |

**Total Estimated Effort:** 190h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Create a Privacy Act assessment for the application or system, and record whether it is a Privacy Act system of records (meaning records can be retrieved by name or identifier).
- [ ] Adopt a System of Records Notice (SORN) template that follows Office of Management and Budget (OMB) Circular A-108, and require all mandatory fields for every required notice element.
- [ ] Define and publish clear rules for when a change counts as “new” versus “significantly modified” data processing records (SORN), based on specific system change events. Require system owners to choose the correct outcome when they submit a change request.
- [ ] Set up a governance approval step that prevents an item being marked “ready for publication” unless every required section of the statement of record (SORN) is complete and matches the system boundary description in the official source.
- [ ] For any new or significantly changed System of Records Notice (SORN), complete and provide evidence for the advance review submissions to the relevant oversight bodies and the appropriate United States congressional committees before publication in the Federal Register.
- [ ] Publish the approved System of Records Notice (SORN) in the Federal Register and keep evidence showing that the published notice matches the approved draft and the specific template version.
- [ ] Schedule regular reviews to confirm the SORN information is accurate, and rerun the checks for completeness and consistency whenever the system changes in a way that could affect the SORN content.


---

#### PT-6.1 — Routine Uses (Enhancement)

This requirement is about making sure the organisation’s published descriptions of when personal information may be shared are still correct and still make sense. Every 90 days, the organisation must review every “routine use” listed in its Privacy Act system of records notice to confirm that the wording matches what it actually does, and that each sharing purpose still fits with the original reason the information was collected. Without this, outdated or overly broad sharing permissions could remain in place, which could lead to personal data being used or shared in ways people did not expect. This can cause legal, reputational, and financial harm.

To meet this expectation, the organisation should keep a complete list of all routine uses in the notice, check each one for accuracy and fit, record the result for every routine use, and ensure no published routine use is missed. If any routine use is found to be inaccurate or not a good fit, the organisation must take follow-up action, such as updating the notice or recording a clear, approved reason for not changing it.

##### 90-day routine-use review register with notice compatibility checks

- Category: Manual
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Extract routine-use entries from current system of records notice(s) and build the authoritative Routine-Use Review Register dataset (including stable internal identifiers, published text, purpose statement, user categories) | Compliance Manager | Enterprise | 24h | — |
| Define the 90-day review workflow requirements (100% coverage, review cadence, required fields for Accuracy/Compatibility determinations, evidence link format, closure rules for “needs change”) and publish as an internal operating procedure | Privacy Officer / Data Protection Officer | Enterprise | 16h | — |
| Configure the review register workflow in the organisation’s case/workflow system (e.g., ticketing/records workflow) to generate review tasks for all routine uses every 90 days and enforce mandatory completion fields | Operations Lead | Enterprise | 32h | £3,000 |
| Establish evidence collection guidance and templates for reviewers (acceptable evidence types, how to link disclosure logs/agreements/procedures/contract clauses/system documentation) and train reviewers on how to record rationales | Compliance Manager | Enterprise | 20h | — |
| Implement “needs change” handling: create linked notice-update action pathway and a documented justification template with required sign-off steps (privacy/legal authority) | Legal/Compliance (as applicable) | Enterprise | 18h | — |
| Produce the audit-ready 90-day cycle report format and automate/standardise report generation from the register (completion status, determinations, rationales, evidence links, corrective actions/justifications) | Quality Assurance Lead | Enterprise | 20h | £2,500 |
| Run the first full 90-day cycle end-to-end (execute reviews for 100% of routine uses, resolve any “needs change” outcomes, and issue the first audit-ready report) | Project Manager | Enterprise | 40h | — |

**Total Estimated Effort:** 160h  
**Total Estimated Cost:** £5,500

###### Actions Required for Compliance

- [ ] Create a routine-use review register and fill it with the routine-use entries from the current system of records notice.
- [ ] Give every routine use a stable internal reference number, and record the published wording, its purpose, and the categories of users it applies to.
- [ ] Set up a process to open review tasks for all routine uses every 90 days.
- [ ] Define reviewer prompts that require reviewers to make clear decisions about whether the information is accurate and whether it matches the evidence linked in the system.
- [ ] Implement closure rules that require either (1) an updated linked notice, or (2) an approved documented justification for every “needs change” finding.
- [ ] Produce and store a report for audit purposes covering the last 90 days. It must list every routine use, the results, the reasons for each use, and any corrective actions taken.


---

#### PT-6.2 — Exemption Rules (Enhancement)

This requirement is about making sure that any legal exemptions the organisation uses to handle personal data are still the correct ones, have been properly authorised, and are described accurately. If these checks are not done regularly, the organisation could end up relying on outdated or incorrect exemption rules, or claiming an exemption that was never formally issued. This could mean people’s rights are not properly protected, and could expose the organisation to legal action and reputational damage.

To meet this expectation, the organisation must, at least every 90 days, review every Privacy Act exemption it currently relies on for the relevant set of records. For each exemption, it must confirm that:
- it is still appropriate and necessary under the law
- it has been formally issued as official regulations
- it is described accurately and consistently in the organisation’s published notice for those records, including the system names, the specific legal provisions covered, and the documented reasons and explanation for why the exemption is necessary and appropriate

The organisation must record the results of these checks each time.

##### Automated 90-day review workflow for Privacy Act exemption rules

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define the Privacy Act Exemption Register data model (fields, validation rules, review status states, evidence references, escalation rules) and produce implementation-ready specifications | Compliance Manager | Enterprise | 24h | — |
| Build the “Privacy Act Exemption Register” (authoritative system of record) including CRUD interfaces, audit logging, and role-based access controls | Platform Engineer | Enterprise | 56h | £12,000 |
| Implement evidence integration: connectors/adapters to the System of Records Notice repository and the Promulgated Regulations repository (including search, excerpt capture, and citation verification workflow inputs) | DevOps Lead | Enterprise | 64h | £18,000 |
| Configure the automated 90-day scheduled workflow to generate review tasks for every exemption entry, including reviewer assignment, SLA/timers, and evidence capture prompts for the three required checks | Operations Lead | Enterprise | 40h | £6,000 |
| Implement policy-as-code style workflow validation to prevent task closure unless required evidence fields are populated; add “Unverified” outcome and automatic escalation when regulation citation cannot be verified | Security Engineer | Enterprise | 48h | £10,000 |
| Create reporting and audit exports for each review cycle (pass/fail/needs change/unverified), including timestamp, reviewer identity, evidence links, and immutable audit trail | Quality Assurance Lead | Enterprise | 24h | — |
| Conduct end-to-end testing, including edge cases (missing citations, notice mismatch, multi-system exemptions), remediation of defects, and run a pilot cycle with sampled exemptions | Project Manager | Enterprise | 40h | £2,500 |
| User enablement and operational handover: training for DPO/Privacy/Legal reviewers, runbooks for escalation, and assurance sampling procedure for completed reviews | Service Delivery Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 320h  
**Total Estimated Cost:** £48,500

###### Actions Required for Compliance

- [ ] Define the Privacy Act Exemption Register data model, including: system name(s), which Privacy Act provisions are exempted, the relevant regulation citation, the reasons for each exemption, an explanation of why each exemption is necessary and appropriate, and how each exemption maps to the relevant notice section.
- [ ] Update the register using the system of records notice repository and the published regulations repository, making sure each system name matches exactly one exempted provision.
- [ ] Set up a scheduled 90-day process that creates a review task for every exemption record and prevents the record from being closed until the required evidence fields are completed.
- [ ] Set up automated checks to compare each register entry with the relevant notice text (system name(s) and the provisions that are exempt) and with the regulation references (so the source can be verified).
- [ ] Set the escalation process so that any regulation citation that has not been verified is marked **Unverified** and sent to **Privacy/Legal** for resolution.
- [ ] For every review result, enable audit logging to record the date and time, who carried out the review, the outcome (pass, fail, needs changes, or unverified), and references to the supporting evidence. Keep these records for audit purposes.


---

### PT-7 — Specific Categories of Personally Identifiable Information (Control)

This requirement is about making sure personal information is only used for the specific purposes the organisation is allowed to use it for, and that the most sensitive types of personal data are handled with extra care. Without this, staff could use personal details for the wrong purpose, share them more widely than they should, or expose them if they are intercepted while being sent or accessed by people who do not genuinely need the information. This can lead to privacy breaches, legal issues, and loss of trust.

To meet this expectation, the organisation must clearly define and document the authorised purposes for each category of personal information, and make sure day-to-day handling matches those purposes. For categories that are treated as Secret, International Traffic in Arms Regulations (ITAR), or otherwise regulated, the organisation must protect the data by encrypting it both while it is being transferred and while it is stored, limit access to the smallest number of people who need it, and require approval based on job role before anyone can access or use it.

##### Enforce PII processing conditions by category with regulated protections

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define PII category taxonomy and regulated classification mapping (Secret/ITAR/regulated flags) and publish as version-controlled governance artefact | Data Protection Officer / Privacy Lead | Enterprise | 24h | — |
| Implement policy-as-code runtime enforcement for authorised purposes per PII category (collect/store/share/export/retain restrictions) | System Design Authority | Enterprise | 80h | — |
| Implement data tagging and propagation across application surfaces (API payloads, DB schema/fields, message topics, exports) with purpose-drift prevention checks | Software Lead | Enterprise | 96h | — |
| Enforce regulated protections: TLS/mTLS requirements for regulated flows and encrypted storage for regulated fields/records (including encrypted backups) | Security Engineer | Enterprise | 72h | £25,000 |
| Implement least-privilege access model for regulated PII (RBAC/ABAC integration, minimum roles per function, service account scoping) | IAM/Identity Architect | Enterprise | 64h | — |
| Build role-based approval workflow for regulated access/use (ticketing integration, time-bounded entitlements, approval reference capture) | Operations Lead | Enterprise | 56h | £12,000 |
| Implement audit logging and SIEM forwarding for category tag, requested purpose, authorisation outcome, approval reference, and encryption enforcement indicators; validate audit evidence completeness | Security Operations Lead | Enterprise | 48h | £8,000 |
| Operationalise governance: change control for category-to-purpose mapping, periodic review cadence, and release pipeline gates for policy/tagging enforcement | Compliance Manager | Enterprise | 32h | — |

**Total Estimated Effort:** 472h  
**Total Estimated Cost:** £45,000

###### Actions Required for Compliance

- [ ] Create a clear set of personal data (PII) categories, and explicitly state which categories are classified as Secret, subject to the International Traffic in Arms Regulations (ITAR), or otherwise regulated.
- [ ] Convert **pt-07_odp authorised purposes** into enforceable policy rules for each **personal information (PII)** category.
- [ ] Set up persistent personal data (PII) tagging in the application so that category labels carry through all application programming interfaces (APIs), storage, and exported reports.
- [ ] Require encryption while data is being sent and when it is stored for Secret, International Traffic in Arms Regulations (ITAR), and regulated personally identifiable information (PII) records, and for their backups.
- [ ] Use least-privilege role-based access control (RBAC) to authorise access to, and processing of, regulated personal data only for those who need it.
- [ ] Add role-based approval checks (role-based access control) before any regulated personal data (PII) can be accessed or used, and only grant time-limited permissions after approval.
- [ ] Set up audit logging to record the category, purpose, authorisation decision, and approval reference, then send it to security information and event management (SIEM).


---

#### PT-7.1 — Social Security Numbers (Enhancement)

This expectation is about using Social Security numbers only when you genuinely need them, and being clear with people about why you are asking for them. Without this, organisations may collect and keep these highly sensitive numbers for longer than necessary, use them for purposes that are not essential, or accidentally treat someone differently simply because they do not want to share their number—potentially affecting their lawful rights, benefits, or access to services.

To meet this expectation, the organisation must actively reduce unnecessary collection, storage, and use of Social Security numbers, and look for other ways to identify people that do not rely on them. It must also make sure that if someone refuses to provide their Social Security number, the organisation does not deny any legal right, benefit, or privilege for that reason.

Finally, whenever the organisation asks for a Social Security number, it must clearly explain whether providing it is required or optional, the legal or other basis for requesting it, and exactly how the number will be used.

##### Minimise SSN processing via purpose gating and identifier substitution

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Deliver SSN touchpoint inventory (UI, APIs, batch jobs, reports, data stores, messaging/ETL/ELT, third-party flows) with evidence links and data-flow diagrams | Project Manager | Enterprise | 40h | — |
| Create and operationalise the SSN justification register template and workflow (purpose, necessity, legal basis, retention expectation, approval owner) and run sign-off for all identified SSN fields/flows | Compliance Manager | Enterprise | 32h | — |
| Refactor identity model and joins to use stable internal subject identifiers (update core data models, reporting views, analytics datasets, and integration contracts where feasible) | System Design Authority | Department | 56h | — |
| Implement purpose-gated SSN capture controls in application layer (approved-purpose flag per workflow/API endpoint; default SSN optional; block non-approved and free-text entry paths) with automated tests | Software Lead | Department | 72h | — |
| Add CI/CD and runtime enforcement (static checks for SSN-as-identifier usage in code/config; schema validation; unit/integration tests; runtime validation and audit logging for any SSN capture attempts) | DevOps Lead | Enterprise | 48h | — |
| Implement tokenisation/vaulting and downstream masking for any remaining SSN storage (vault integration, access restrictions to narrow role set, masked values in downstream consumers, key management alignment) | Security Engineer | Enterprise | 64h | £25,000 |
| Produce audit-ready evidence pack (inventory report, justification register outputs, enforcement/test results, data-flow updates, and access control evidence) and support compliance review/attestation | Compliance Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 336h  
**Total Estimated Cost:** £25,000

###### Actions Required for Compliance

- [ ] Carry out an end-to-end check of where Social Security numbers are used across the application, databases, application programming interfaces (APIs), batch jobs, reports, and integrations.
- [ ] Set up and keep a register of Social Security Number (SSN) justifications, and require approval from the privacy or compliance team and the system owner for each SSN data flow.
- [ ] Update the identity and data model linking to use an internal subject identifier instead of a Social Security number (SSN).
- [ ] Set up purpose-based data capture controls so that Social Security Number (SSN) fields are optional and can only be entered for approved business processes and approved system locations (workflows/endpoints).
- [ ] Add continuous integration and continuous delivery (CI/CD) and code and configuration checks to prevent Social Security numbers (SSNs) from being used as the main identifier in new services.
- [ ] Identify and secure any remaining storage of United States Social Security numbers (SSNs) by tokenising or vaulting them, and ensure downstream systems receive masked or tokenised values.


---

#### PT-7.2 — First Amendment Information (Enhancement)

This requirement is about stopping the organisation from collecting or using information that could reveal how people exercise protected rights—such as what they say, whether they protest, or what they believe—unless there is a very clear legal reason to do so. Without this protection, the organisation could wrongly monitor or analyse lawful expression. This creates a serious risk of unfair treatment, discouraging people from speaking freely, and causing legal or reputational harm.  

To meet this expectation, the organisation must put in place and follow privacy and legal procedures that, by default, prevent this kind of information from being processed. Staff must only proceed if Parliament has expressly allowed it, if the person has given clear, specific permission, or if it is directly relevant to, and carried out within the scope of, an officially authorised law-enforcement activity.  

For any approved use, the organisation must record which permission applies and consult senior privacy and legal advisers to confirm the decision is correct.

##### Block First Amendment rights-behaviour processing without legal basis

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define “First Amendment rights-behaviour” taxonomy, classification rules, and evidence requirements (statute / individual authorisation artefact ID / law enforcement authorisation reference + scope) | Compliance Manager | Enterprise | 32h | — |
| Design rights-behaviour detection and labelling in the application/data intake layer (taxonomy mapping, free-text/attachment handling approach, confidence thresholds, and false-positive/false-negative handling) | System Design Authority | Enterprise | 40h | — |
| Implement block-by-default intake gate across all ingestion paths (UI uploads, API ingestion, case management ingestion, batch loads, message ingestion, export pre-checks) with deterministic halt behaviour when no approval token is present | Software Lead | Enterprise | 120h | — |
| Build approval workflow with mandatory privacy/legal escalation and structured, machine-checkable legal basis fields (including delegated authority path controls if applicable) | Project Manager | Enterprise | 56h | — |
| Implement “no processing before basis” enforcement and propagation controls (prevent persist/index/transform/export until token validated; attach basis to lineage metadata; enforce downstream inheritance) | Security Engineer | Enterprise | 96h | — |
| Create immutable audit logging and evidence package (approval record integrity, lineage linkage, retention alignment, and audit query/reporting endpoints) | Operations Lead | Enterprise | 48h | — |
| Develop automated tests and validation harness (unit/integration/e2e tests for each ingestion/export path; negative tests for unauthorised processing; regression suite for lineage propagation) | Quality Assurance Lead | Enterprise | 64h | — |
| Security/compliance review, threat modelling, and production readiness sign-off (including access control review, monitoring/alerting for gate denials, and change management release) | Cyber Security Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 488h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define a “First Amendment rights behaviour” data category (taxonomy) and link it to where the data comes in (user interface, application programming interface, uploads, attachments, and batch loads).
- [ ] Set up a “block by default” intake gate that stops storing, indexing, analysing, and exporting data when the system detects rights-related behaviour without an approval token.
- [ ] Set up an approval process that requires the reviewer to choose exactly one allowed option—either (1) a specific law (statute), (2) explicit permission from the individual, or (3) authorised law enforcement action within scope—and to provide the required supporting evidence for that choice.
- [ ] Set up mandatory escalation so that senior privacy and legal counsel must approve any request to process personal data before processing can begin.
- [ ] Link the approved legal basis—and, where relevant, the law-enforcement scope—to the dataset’s lineage information, and make sure any later processing jobs automatically use the same information.
- [ ] Add automated tests and monitoring to confirm that processing does not start until the legal basis is in place, across every data intake and data export route.


---

### PT-8 — Computer Matching Requirements (Control)

This requirement is about making sure that when the organisation compares information from different records to decide whether someone is eligible for benefits or owes money, the process is properly authorised, clearly agreed, and fair to the person affected. Without these safeguards, the organisation could rely on incorrect matches, wrongly accuse someone, or take action without giving them a chance to understand and challenge the result, which could cause real financial and personal harm.

To meet this expectation, before starting any matching programme the organisation must:
- obtain written approval from the Data Integrity Board,
- create and sign a formal matching agreement that explains what will be compared and how, and
- publish a matching notice in the Federal Register.

If the organisation plans to take adverse action based on the results, it must independently check the matching information first. Then, before any adverse action is taken, it must tell the individual what the findings are and give them a fair opportunity to contest them.

##### Matching programme lifecycle gates with independent verification

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define the “computer matching programme lifecycle” control model (workflow states, mandatory evidence fields, adverse-action triggers, and contest/waiver rules) and publish it as an enterprise-standard configuration schema | Compliance Manager | Enterprise | 24h | — |
| Configure GRC/workflow system to create governed matching programme records with mandatory fields (purpose, data sources/records, matching logic version, retention, investigative follow-up, adverse-action triggers) and enforce role-based approvals | Project Manager | Enterprise | 32h | — |
| Implement policy-as-code workflow gates to block (a) scheduling matching jobs, (b) releasing match outputs via APIs, and (c) opening adverse-action cases until evidence is attached for written approval, signed matching agreement, and required disclosure artefact | Software Lead | Enterprise | 56h | — |
| Build independent verification pipeline that re-computes/validates match outputs in a separate execution context and records verification outcomes against agreed criteria (reconciliation rules, error-rate thresholds, exception handling) | Security Engineer | Enterprise | 72h | £18,000 |
| Integrate verification evidence binding so adverse-action workflow checks verification pass status and links verification evidence to the specific match batch/case (including immutable references) | Platform Engineer | Enterprise | 24h | — |
| Implement individual notice and contest workflow from approved templates, link it to the case record, and enforce that adverse action cannot proceed until notice is issued and contest window/steps are completed or formally waived | Operations Lead | Department | 40h | — |
| Produce audit-ready evidence package (immutable logs for dataset lineage/hashes, job parameters, matching logic version, workflow approvals/signatures, verification results, and case outcome) and integrate with SIEM/monitoring for retention and traceability | Data Protection Officer | Enterprise | 40h | £6,000 |

**Total Estimated Effort:** 328h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Set up the matching programme lifecycle process in the governance, risk and compliance (GRC) tool, including required supporting evidence fields: approval, a signed agreement, and a disclosure document.
- [ ] Set up automated policy checks and workflow “gates” that stop job scheduling, releasing match results through the application programming interface (API), and creating adverse-action cases until the required evidence is available.
- [ ] Set up an independent verification process that runs in a separate environment and records the verification results for each match batch or case.
- [ ] Require application-level checks so that any adverse-action workflow only proceeds after a successful verification and includes linked supporting evidence.
- [ ] Set up the process for generating each notice and handling any contest, and do not take any negative action until the notice and contest steps are completed or the steps are formally waived.
- [ ] Set up tamper-evident audit logs that record the full dataset history (lineage), the job settings used, the matching logic and version, the results of verification checks, and the governance approvals.

