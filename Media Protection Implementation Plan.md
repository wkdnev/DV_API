### MP-1 — Policy and Procedures (Control)

This requirement is about making sure the organisation has clear, written rules for protecting any physical or digital storage media, and that everyone who needs to follow those rules knows what to do. Without an up-to-date policy and practical, step-by-step procedures, important information could be handled incorrectly, lost, or exposed. This could lead to financial loss, legal issues, and damage to trust.

The organisation must create an organisation-wide media protection policy and supporting procedures. These documents must set out the purpose, what they cover, who is responsible, senior leadership’s commitment, how different parts of the business work together, and how compliance will be checked. They must also align with relevant laws and the organisation’s standards.

The Chief Information Security Officer must be responsible for producing, maintaining, and sharing these documents.

The policy must be reviewed and updated at least every year, and after significant events. The procedures must also be reviewed and updated at least every year, and after significant events, including audit findings, security incidents, or changes to key legal or regulatory requirements.

The policy must be shared with Security and Privacy leadership, Information System Owners, and Media Custodians. The procedures must be shared with all staff who handle media, including Media Custodians and IT Operations staff.

##### CISO-owned media protection policy & procedures lifecycle with evidence

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Establish governance for MP-1 lifecycle: confirm CISO ownership, define roles (Security lead, Privacy lead, Information System Owners, Media Custodians, IT Operations), and set document approval workflow | Compliance Manager | Enterprise | 16h | — |
| Draft organisation-level **Media Protection Policy** (purpose, scope, responsibilities, management commitment, coordination between security and privacy programmes, and high-level MP-family coverage) | Cyber Security Lead | Enterprise | 24h | — |
| Draft organisation-level **Media Protection Procedures** (role-based media handling steps for Media Custodians and media-access personnel; references to MP-family controls implemented; operational guidance for production/test/DR segregation) | Security Engineer | Enterprise | 32h | — |
| Create legal/regulatory applicability mapping and review checklist (explicit mapping to relevant laws/regulations/standards and executive directives; include ITAR/EAR, HIPAA, GDPR, CMMC, NIS2 as applicable triggers) | Data Protection Officer | Enterprise | 20h | — |
| Define controlled review/update trigger model and evidence requirements (annual + triggering events; decision outcome logging: update required/no update with rationale; include audit findings, incidents/breaches, and specified regulatory changes) | Compliance Manager | Enterprise | 16h | — |
| Implement audit-ready document control and dissemination evidence (versioning, effective dates, approvals; publish to policy hub; targeted notifications; procedures access/acknowledgement capture for media-access roles) | Operations Lead | Enterprise | 24h | £3,000 |
| Run review/consultation cycles with Security and Privacy leadership and key operational stakeholders; incorporate feedback and obtain final approvals for policy and procedures | Project Manager | Enterprise | 24h | — |

| Total Estimated Effort | 156h |  |
|---|---:|---:|
| Total Estimated Cost |  | £3,000 |

###### Actions Required for Compliance

- [ ] Appoint the Chief Information Security Officer (CISO) as the official responsible for managing the media protection policy and procedures.
- [ ] Draft and get approval for an organisation-wide media protection policy. It should set out the policy’s purpose, where it applies, who is responsible for what, and how security and privacy teams will coordinate.
- [ ] Draft and get approval for role-based media protection procedures that explain how the policy will be put into practice (not just a repeat of the media protection controls).
- [ ] Define and document the distribution lists for policy documents (Security and Privacy leadership, Information System Owners, and Media Custodians) and the procedures for sharing them (all staff who can access media, including Media Custodians and IT Operations staff).
- [ ] Set up a controlled document process that includes version numbers, start dates, and records of who approved each document.
- [ ] Set review and update triggers, and record the results: review the policy every year and whenever a trigger event occurs; review the procedures every year and whenever a trigger event occurs, and also after audit findings, incidents, or breaches, and after any specified regulatory changes.
- [ ] Publish the policy and procedures on the organisation hub, and keep audit evidence showing they were shared and that the documents are up to date.


---

### MP-2 — Media Access (Control)

This requirement is about ensuring that only the right people can handle sensitive information stored on physical items, such as flash drives, external hard drives, magnetic tapes, CD and DVD discs, and also paper records and microfilm. Without this, confidential or secret information could be accidentally or deliberately taken, copied, or viewed by unauthorised staff, visitors, or contractors, which could cause serious harm such as privacy breaches, regulatory problems, and damage to trust.

To meet this expectation, the organisation must clearly define and document who is allowed to access digital sensitive media (the system development team, authorised system administrators, and the information system owner) and who is allowed to access paper or microfilm sensitive records (authorised healthcare providers and the medical records custodian). It must put these rules into written policies and step-by-step procedures, ensure secure storage facilities are in place, restrict physical access to those storage areas, and keep records showing who accessed or received the media and when, so the organisation can demonstrate that the rules are followed in practice.

##### Controlled custody for in-scope media with role-based release

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Draft and publish the “System Media Protection / Media Access” procedure mapping in-scope digital and non-digital media types to authorised roles, including approval/exception handling | Compliance Manager | Enterprise | 24h | — |
| Define media register data model and unique identifier scheme (serial/label + classification + storage location + owning system/environment), and create register templates | Data Protection Officer | Enterprise | 16h | — |
| Implement physical custody controls for digital media (locked vaults/controlled rooms, access restrictions, badge/key control, storage location mapping) | Infrastructure Lead | Enterprise | 32h | £6,000 |
| Establish sign-out/request/return workflow and logging for digital media, including identity/role verification steps and approver/authoriser requirements | Operations Lead | Enterprise | 24h | — |
| Establish custody controls for non-digital media (badge/key restricted libraries, request/return logging tied to the media register) | Service Delivery Manager | Enterprise | 20h | £2,500 |
| Create audit-ready evidence package (retention rules, retrieval process, sampling approach, and documented audit trail requirements) | Compliance Manager | Enterprise | 16h | — |
| Conduct role-mapping validation and pilot release testing (ensure only authorised roles can obtain media; verify logs capture required fields; remediate gaps) | Security Engineer | Enterprise | 24h | — |

| Total Estimated Effort | 176h | Total Estimated Cost | £8,500 |

###### Actions Required for Compliance

- [ ] Publish a media access procedure that clearly limits access to in-scope Confidential/Secret media to the defined authorised roles.
- [ ] Create and keep a media register that records, for every in-scope item, a unique identifier, its classification, and where it is stored.
- [ ] Set up secured “locked vault” areas (controlled rooms) for digital media, and allow access only to authorised roles.
- [ ] Set up a sign-out process for digital media that records: who requested it (their identity and role), the media item identifier, the reason for the request, the relevant dates and times, and who approved or authorised it.
- [ ] Set up logging of requests and responses, and store non-digital records (paper and microfilm) in a secure, access-controlled way limited to authorised roles.
- [ ] Keep records of media access (the access register plus sign-out, request, and return logs) for audit purposes, and carry out regular checks that the access records are complete and accurate.


---

### MP-3 — Media Marking (Control)

This requirement ensures that all sensitive information is clearly labelled, whether it is stored on a USB drive, hard drive, tape, disc, or paper. The labels must make it clear who the information may be shared with and how it must be handled. Without clear labelling, confidential material could be accidentally given to the wrong people, handled incorrectly, or left unprotected, increasing the risk of unauthorised access, loss, or improper disclosure.

The organisation must have clear written rules and step-by-step instructions for how to apply these labels. It must also keep an up-to-date list of the exact labels it uses, and assign responsibility to the appropriate staff. Media can be exempt from labelling only while it remains inside the organisation’s approved secure areas and is never taken outside them. This applies only within access-controlled, escorted areas such as accredited data centre rooms, secure server rooms, and controlled laboratories.

##### Enforce media marking with controlled-area exemption via workflow

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define controlled media marking attribute catalogue (distribution limits + handling caveats) including exact human-readable label text/format per media type | Compliance Manager | Enterprise | 24h | — |
| Define controlled-area workflow rules (accredited enclave list, access/escort requirements, and conditions under which exemption is valid) | Security Engineer | Enterprise | 20h | — |
| Design media lifecycle workflow integrated with ITAM/CMDB: marking required for non-public info; “unmarked” allowed only when inventory location is within controlled areas and movement history confirms no removal | System Design Authority | Enterprise | 40h | — |
| Implement label template management and marking confirmation step (barcode/QR optional): generate label content, capture template/version, and require scan/record before check-out/movement | Software Lead | Enterprise | 56h | £18,000 |
| Build audit evidence generation and alerting: record label template/version, applied attributes, controlled-area location at exemption, and movement history; alert on items outside controlled areas missing marking evidence | Cyber Security Lead | Enterprise | 48h | £12,000 |
| Extend workflow to non-digital media: controlled stickers/labels on immediate containers/cases/sleeves; link container identifiers to records management identifiers for exemption audibility | Operations Lead | Department | 24h | — |
| Test, assurance, and rollout: integration testing with ITAM/CMDB movement events, workflow enforcement validation, evidence completeness checks, and production release with runbook | Quality Assurance Lead | Enterprise | 32h | £6,000 |

**Total Estimated Effort:** 244h  
**Total Estimated Cost:** £36,000

###### Actions Required for Compliance

- [ ] Define and publish the organisation’s list of controlled areas (including the access rules and escort requirements) that is used to check whether the MP-3 exemption applies.
- [ ] Create a catalogue of media marking attributes that is managed with version control, covering distribution limits and handling cautions, grouped by information type and media type.
- [ ] Implement a media lifecycle process, linked to IT asset management (ITAM) and the configuration management database (CMDB), to require label creation and confirmation that labels have been applied when media is received or created, and again when media is moved.
- [ ] Set up the process so an exemption (unmarked) is allowed only when the item is in a controlled area and the movement records show it was not removed.
- [ ] Use approved label templates (with optional barcode or QR code) and require confirmation based on scanning and recording before any media is checked out.
- [ ] Create audit records and alerts for any media recorded outside controlled areas where there is no evidence of proper marking.


---

### MP-4 — Media Storage (Control)

This requirement is about keeping all removable storage items and paper records physically secure, so sensitive information cannot be lost, stolen, or accessed by the wrong people. Without it, USB sticks, removable drives, SD cards, magnetic tapes, optical discs, and paper or microfilm could be left unprotected, removed without detection, or handled incorrectly, which could expose confidential or secret information.

The organisation must keep every type of removable digital media and every paper or microfilm record under physical control in controlled areas that use badge access. Entry and exit must be recorded, and inventories must be used to track what is stored and who is allowed to take items out and return them.

Secret-labelled digital media must be stored in the CML vault, with badge-controlled access, CCTV monitoring, and item-by-item inventory. Access must be carried out by two authorised people.

Confidential-labelled paper and microfilm must be kept in locked storage within the CML document room, also with badge-controlled access and inventory tracking.

All system media must be protected until it is destroyed or securely wiped (sanitised) using approved equipment, methods, and procedures.

##### Implement CML for controlled media with logged access and dual-control

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define CML scope and register schema (media types, classification labels, item ID format, statuses, location model, custodian model) and produce the CML register template | Compliance Manager | Enterprise | 16h | — |
| Establish controlled areas operating model (CML vault and CML document room): access control requirements, badge-controlled entry/exit expectations, CCTV coverage requirements, and locked-storage standards | Security Engineer | Enterprise | 24h | £8,000 |
| Procure and deploy physical labelling and inventory aids (barcode/QR labels, label printers, tamper-evident seals where required, inventory tags, cabinet/vault storage consumables) | Infrastructure Lead | Enterprise | 12h | £3,500 |
| Implement inventory-led accountability procedures (item creation, movement transactions, check-out/return workflow, discrepancy handling, audit trail requirements, evidence checklist) and publish CML operating procedures | Compliance Manager | Enterprise | 28h | — |
| Configure dual-control for Secret-labelled vault access (authorised-person list, dual-approval process, access pairing/rotation rules, exception handling, and documented access governance) | Cyber Security Lead | Enterprise | 20h | — |
| Operationalise audit evidence and reconciliation (badge logs retention mapping, CCTV access evidence capture approach, monthly/quarterly reconciliation cadence, discrepancy investigation and remediation record templates) | Operations Lead | Enterprise | 20h | — |
| Train CML Custodian, requestors, and internal audit stakeholders; run tabletop test and one controlled pilot issuance/return cycle with evidence collection | Project Manager | Enterprise | 24h | £2,000 |
| Perform go-live readiness review against acceptance criteria and produce audit-ready pack (policies, procedures, register sample, evidence samples, reconciliation results) | Quality Assurance Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 150h  
**Total Estimated Cost:** £13,500

###### Actions Required for Compliance

- [ ] Document the organisation’s approved list of physical and non-physical media types that are covered within the configuration management list (CML) scope.
- [ ] Set up the CML vault and the CML document room as the only approved controlled areas: the CML vault for Secret-labelled digital data, and the CML document room for Confidential-labelled non-digital media.
- [ ] Create and run an inventory register that assigns a unique ID, a category label, and records the current location and status for every media item.
- [ ] Put in place a documented process for checking items out and back in. The process must record the item ID, the person’s identity, the date and time, and the reason for the change, and it must update the inventory records.
- [ ] Require two people to approve before accessing the Secret-labelled digital media vault, and limit access to authorised roles only.
- [ ] Carry out regular stock checks by comparing the results with the official register, and record how you investigate any differences and how you fix them.


---

#### MP-4.2 — Automated Restricted Access (Enhancement)

This requirement is about maintaining strict, door-by-door control over who can physically reach places where important media is stored. Access must be controlled at the external entrances using keypads and card readers. Without this, unauthorised people could try doors repeatedly until they find a way in, or enter and then tamper with or steal the stored information, causing serious financial and operational harm.

To meet this expectation, the organisation must set up the keypads and card readers so that entry is allowed only for people who are listed as authorised in the access list linked to those devices. The access system must automatically record every attempt to enter the media storage areas made using the keypads or card readers, and it must also automatically record every successful entry. These records must be kept as part of the organisation’s access and audit information, so that access behaviour can be reviewed when needed.

##### PACS keypad/card readers with per-door ACLs and automated access logs

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Produce PACS enforcement-point inventory mapping each media storage area to external entry points, keypad/card reader devices, and door controllers (including device IDs and locations) | Project Manager | Enterprise | 16h | — |
| Configure per-door/per-reader ACLs aligned to the organisation’s authorised access list for each media storage area (including identity/credential mapping and least-privilege defaults) | Cyber Security Lead | Enterprise | 40h | — |
| Enable and verify automated event generation for both access attempts (denied/failed/attempted) and access granted events on each configured reader/door controller | Security Engineer | Enterprise | 24h | — |
| Implement log forwarding from PACS to the central SIEM/log platform (agent/syslog/API as supported), including required field mapping (identity/credential, reader/door location, timestamp, result) | DevOps Lead | Enterprise | 32h | £3,000 |
| Configure log retention, restricted administrative access to log stores, and tamper-evident/immutable retention controls where supported by the SIEM/log platform | Compliance Manager | Enterprise | 16h | £2,500 |
| Execute end-to-end validation tests per media storage area (unauthorised attempt → attempt event; authorised entry → granted event; confirm correct door/reader mapping and timestamps in central logs) and produce audit-ready evidence pack | Quality Assurance Lead | Enterprise | 24h | — |
| Establish operational governance for ACL and reader/door configuration changes (change tickets, approvals, configuration baselines, and periodic access review triggers) | Operations Lead | Enterprise | 20h | — |

**Total Estimated Effort:** 172h  
**Total Estimated Cost:** £5,500

###### Actions Required for Compliance

- [ ] Take an inventory of every media storage area, and record which external entry point connects to the specific keypad or card reader device and the door controller for that door.
- [ ] Set up access rules for each reader and each door so that only authorised identities can access each media storage area entry.
- [ ] Set up automatic logging for both access attempts and successful access events on the access control system.
- [ ] Check that the log records include: the person’s identity or credential, the reader or door location, the date and time, and the outcome (granted or denied).
- [ ] Send access control event records to the central security information and event management (SIEM) / log platform, and apply the required record retention periods and access restrictions.
- [ ] Carry out authorised and unauthorised access tests for each media storage area, and keep records of all logged attempts and any access that was granted.
- [ ] Place access control list (ACL) changes and reader/door configuration changes under formal change control, using approved configuration baselines.


---

### MP-5 — Media Transport (Control)

This requirement is about protecting sensitive information when it is taken off secure premises, whether it is stored on removable devices or on paper. It must be kept safe so it cannot be lost, accessed by the wrong people, or changed without being noticed. Without these safeguards, a misplaced USB drive, external hard drive, tape, CD/DVD, or a confidential sheet of paper or microfilm could be stolen or altered while it is being transported. This could lead to data breaches, fraud, and regulatory and reputational harm.

The organisation must clearly define what counts as “system media” and which locations are treated as controlled areas. It must then ensure that, when media leaves those areas, it is protected during transit. Digital media must be encrypted using approved encryption, with the encryption keys managed by the system owner. Non-digital media must be stored in locked, access-controlled containers.

All media must be transported in locked, tamper-evident packaging, with chain-of-custody records. The organisation must be able to account for the media throughout the journey, document each stage of release, handover, and actual movement, and ensure that only named, authorised personnel handle transport.

##### Encrypted removable media release with chain-of-custody tracking

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define media transport scope and “controlled vs outside controlled areas” mapping (including in-scope media types and documentation requirements) | Compliance Manager | Enterprise | 24h | — |
| Select and document approved FIPS 140-2 validated encryption mechanism for removable digital media, including system-owner key management model and RBAC/audit requirements | System Design Authority | Enterprise | 32h | — |
| Configure/extend enterprise key management integration (KMS/HSM-backed) to support system-owner key custody, role-based access, and encryption completion audit evidence | Security Engineer | Enterprise | 48h | £18,000 |
| Build/implement chain-of-custody workflow (release gate, transport-process entry, handover events incl. courier handoff, receipt/return confirmation) with container/seal ID validation and tamper-evident record integrity | Software Lead | Department | 72h | £25,000 |
| Integrate workflow authorisation with enterprise IAM (authorised media transport role/group; enforce least privilege for release/handover/receipt actions; ensure all actions are logged) | IAM Architect | Enterprise | 40h | £6,000 |
| Implement operational packing/sealing controls integration (locked container/seal ID capture, evidence attachment for encryption completion/packing, and exception handling for failed seals/returns) | Operations Lead | Department | 32h | — |
| Establish audit-ready retention, reporting, and sampling evidence pack (e.g., last 30/90 days) including consistency checks for custody gaps and matching IDs | Quality Assurance Lead | Enterprise | 24h | — |
| Pilot, test, and harden end-to-end process (digital + non-digital), including tabletop exercises, logging verification, and remediation of control gaps prior to rollout | Project Manager | Business Unit | 40h | £4,000 |

**Total Estimated Effort:** 312h  
**Total Estimated Cost:** £53,000

###### Actions Required for Compliance

- [ ] Publish a media transport standard that sets out which system media types are included, and explains what counts as a controlled area versus an area outside control.
- [ ] Choose and register the approved Federal Information Processing Standards 140-2 (FIPS 140-2) validated encryption method for removable digital media, and record the proof that it has been validated.
- [ ] Set up encryption key management for removable media so that only the system owner can control the keys. Use an enterprise key management service backed by a hardware security module (HSM), with audit logs and role-based access control (RBAC).
- [ ] Set up a media release process that checks for protection before anything is released: either encryption must be completed for digital releases, or the file must be packed into a locked container for non-digital releases.
- [ ] Create chain-of-custody records that document: the release, entry into the transport process, every handover event, and the confirmation of receipt or return—using the container and seal identification numbers.
- [ ] Use tamper-evident locked containers and ensure that only authorised staff can carry out release, handover, and receipt actions within the workflow.


---

#### MP-5.3 — Custodians (Enhancement)

This requirement is about making sure there is one clearly named person responsible for taking charge of, or handing over, company storage items (such as drives, tapes, or other system media) when they leave secure premises. Without this, the wrong person could take responsibility, accountability could become unclear, and sensitive information could be mishandled, lost, or accessed by unauthorised people while it is being transported.

To meet this expectation, the organisation must formally name a specific individual as the custodian for any transport of system media outside controlled areas. The organisation must record that person’s name in its media transport procedures (and in any related plans and records). It must also ensure that the same named custodian carries out the transport every time.

If responsibility needs to change, the handover must be clear and documented before the next transport outside controlled areas. The transport records for each event must show the custodian’s name.

##### Named custodian sign-out/in for out-of-area media transport

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define “controlled areas” boundaries and document out-of-area classification rules (including examples for server rooms, OT zones, and secure handover desks) | Compliance Manager | Enterprise | 16h | — |
| Create and approve a named custodian roster (individuals only), including authorisation criteria, coverage expectations, and periodic review cadence | Operations Lead | Enterprise | 24h | — |
| Design the manual workflow for dispatch/return events, including mandatory fields (asset ID, locations, purpose, named custodian, timestamps) and explicit outgoing→incoming transfer steps | Project Manager | Enterprise | 20h | — |
| Implement sign-out/sign-in evidence capture at the custody point (electronic signature or equivalent), including offline-capable procedure for constrained environments | Service Delivery Manager | Enterprise | 32h | £3,000 |
| Establish record retention and audit retrieval requirements (append-only/tamper-evident approach, indexing by media identifier and time window, access controls) | Data Protection Officer | Enterprise | 20h | — |
| Produce audit-ready templates and operational guidance (dispatch/return record template, custody transfer checklist, custodian roster management SOP) | Compliance Manager | Enterprise | 16h | — |
| Run pilot and control effectiveness validation for out-of-area transport events (test scenarios: single custodian, custody change, offline signing, missing fields prevention) | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 152h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Define and document the limits of the “controlled areas” for the application’s operating environment.
- [ ] Create a list (roster) of named, authorised people who are responsible for transporting system media outside the local area.
- [ ] Update the media transport procedures so that every time media is moved outside the usual area, there is an event-based record showing when it was sent and when it was returned.
- [ ] Make custodian selection mandatory and require custody acknowledgement (an electronic signature or an equivalent method) as part of the dispatch and return process.
- [ ] Add an explicit handover step from the outgoing custodian to the incoming custodian, and make sure it is completed before starting the next out-of-area leg.
- [ ] Set up tamper-evident, append-only retention for transport records, and confirm that audit records can be retrieved using the media ID and the date/time.
- [ ] Train all custodians and relevant operations staff on the mandatory sign-out/sign-in and handover rules, and record that training is completed.


---

### MP-6 — Media Sanitization (Control)

This requirement ensures that when your organisation no longer needs a device, memory card, printer, scanner, or any other equipment, the information stored on it is made permanently unreadable before it is thrown away, passed to someone else, or put back into use. Without this, sensitive information could be recovered by unauthorised people—for example from old computers, phones, network equipment, or even paper records that still contain protected details—leading to privacy breaches, fraud, or regulatory issues.

To meet this expectation, the organisation must securely wipe (sanitise) all digital and non-digital media in scope. This includes storage built into devices and connected equipment (peripherals). It must use approved methods that match the sensitivity of the information, and it must destroy any media that cannot be reliably sanitised.

For disposal of Secret material, the organisation should use the strongest feasible option first. If that is not possible, it should use the next suitable method, destroy the media when required, and keep evidence of what was done.

For release from organisational control, it must sanitise to the approved standard. If it cannot prove the sanitisation was successful, it must destroy the media. It must also record the method used and the outcome.

For reuse, it must sanitise again, remove personal details where applicable, and verify that the process is complete. Vendor or specialist checks should be used when needed.

##### Auditable media sanitisation workflow with NIST 800-88 methods

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define MP-6 sanitisation scope, lifecycle triggers, and in-scope media inventory (digital + non-digital; embedded + removable; endpoints, servers, storage, network components, MFDs, mobile, paper/microfilm where applicable) | Compliance Manager | Enterprise | 24h | — |
| Create NIST SP 800-88 Rev.1-aligned sanitisation decision logic and method selection rules (clear/purge/cryptographic erase/de-identification/destruction; Secret vs other classifications; unverifiable → destruction) | Data Protection Officer | Enterprise | 32h | — |
| Produce sanitisation procedures, evidence requirements, and chain-of-custody/segregation workflow (intake/hold states; tamper-evident handling; operator/authoriser roles; exception handling) | Security Engineer | Enterprise | 40h | — |
| Establish verification and evidence capture standards (what constitutes successful verification per technique; required fields; photo/serial/key-status evidence; retention approach) | Cyber Security Lead | Enterprise | 24h | — |
| Integrate sanitisation triggers into asset/endpoint lifecycle workflows (decommissioning/reuse/disposal; key availability checks; playbook runbooks for endpoints/servers/storage; routing to destruction when verification fails) | Operations Lead | Enterprise | 48h | — |
| Define and implement non-digital media sanitisation approach (destruction/redaction equivalence; facilities workflow; evidence pack; segregation and approvals) | Service Delivery Manager | Enterprise | 24h | — |
| Pilot the end-to-end workflow and perform audit readiness testing (sample-based execution; evidence completeness; gap remediation; sign-off for enterprise rollout) | Project Manager | Enterprise | 32h | — |

| Total Estimated Effort |  |  | **224h** |  |
| Total Estimated Cost |  |  |  | **£0** |

###### Actions Required for Compliance

- [ ] Define and publish the MP-6 sanitisation scope for all types of system storage media, both digital and non-digital, including built-in (embedded) and removable storage.
- [ ] Create sanitisation decision rules that link each data sensitivity level and lifecycle event (disposal, release, reuse) to the approved National Institute of Standards and Technology Special Publication 800-88 (NIST SP 800-88) sanitisation methods and destruction requirements.
- [ ] Set up a controlled process with a clear record of who handled the items and when, covering these stages: intake, cleaning, verification, and release.
- [ ] Standardise how sanitisation evidence is recorded (asset ID, type and location of media, method and settings, verification result, operator and authoriser, and timestamps) and enforce how long it is kept.
- [ ] Include data-sanitisation checklists in the process of removing endpoints and infrastructure, so that cryptographic erasure is used where possible, and backup methods are used when encryption keys are not available.
- [ ] Set a verification requirement and handle exceptions: if sanitisation cannot be verified, send the data or material for destruction and record the reason.
- [ ] Document and carry out the sanitisation (destruction or equivalent removal) of non-digital media, and keep audit-ready records.


---

#### MP-6.1 — Review, Approve, Track, Document, and Verify (Enhancement)

This requirement ensures that when the organisation wipes or destroys old storage media, it does so properly, with clear oversight and evidence. Without this, sensitive information could be left on discarded devices, or media could be disposed of too early or in the wrong way, creating legal, financial, and reputational risk.

The organisation must:
- define which types of media and disposal activities are covered
- follow written procedures
- check each action against its records retention and disposal rules before it happens

For every sanitisation and disposal event, the organisation must record:
- who reviewed it and who approved it
- the type of media
- what data or files were on it
- the sanitisation method used
- the date and time
- who carried it out
- what verification was performed and by whom
- what disposal action was taken

It must also:
- confirm that sanitisation was effective before disposal
- keep these records for the required period
- make them available for authorised review and audit

##### Media sanitisation workflow with independent verification evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define MP-6(1) workflow data model and mandatory fields (reviewer/approver/sanitiser/verifier identities, media type & identifier, files/data description, sanitisation method catalogue, sanitisation timestamps, verification actions/outcome, disposal action/timestamps) | Compliance Manager | Enterprise | 24h | — |
| Publish approved sanitisation methods catalogue and define “verification effectiveness” criteria per media type (including evidence artefact types required for each method) | Data Protection Officer | Enterprise | 20h | — |
| Configure GRC/ITSM workflow with mandatory fields, evidence attachments, and non-bypassable progression rules (block disposal unless verification outcome = effective and evidence attached) | System Design Authority | Enterprise | 56h | — |
| Implement role separation and enforcement (reviewer ≠ approver ≠ sanitiser ≠ verifier) using enterprise IAM/authorisation mappings and workflow transition guards | Security Engineer | Enterprise | 32h | — |
| Integrate workflow with authoritative asset/CMDB and retention/disposition policy checks (pre-fill media attributes; validate legal hold/retention expiry before allowing sanitisation/disposal) | Platform Engineer | Enterprise | 48h | — |
| Implement tamper-evident audit logging and evidence retention (workflow record integrity, attachment immutability where supported, retention period alignment, SIEM event hooks) | Operations Lead | Enterprise | 40h | £12,000 |
| Develop and execute end-to-end test plan (unit/config tests, negative tests for bypass attempts, verification-not-effective routing, audit evidence completeness checks) and remediate findings | Quality Assurance Lead | Enterprise | 32h | — |
| Pilot rollout and operational readiness (training for sanitiser/verifier/approver, runbooks, monitoring dashboards, audit rehearsal for sample cases) | Project Manager | Enterprise | 24h | £3,000 |

**Total Estimated Effort:** 276h  
**Total Estimated Cost:** £15,000

###### Actions Required for Compliance

- [ ] Define mandatory workflow fields that exactly capture the MP-6(1) guidance elements: reviewer, approver, media type, files/data, sanitisation method, date/time, sanitiser, verification action/outcome and verifier, and disposal action.
- [ ] Set up the workflow so that different people have different responsibilities (the reviewer must not be the approver, sanitiser, or verifier) and so that proof of verification is mandatory.
- [ ] Integrate the workflow with the organisation’s official asset and configuration management database (CMDB) so that it requires an asset or media identifier and automatically fills in the media details.
- [ ] Add a step to check the retention and disposal rules before any sanitisation or disposal. If the required retention or legal-hold conditions are not met, the sanitisation or disposal must be blocked.
- [ ] Set up an independent verification step so disposal cannot begin unless the verification result is recorded as effective, with supporting evidence attached.
- [ ] Set up tamper-evident audit logs and keep workflow records and evidence attachments for the required audit period.
- [ ] Publish the approved sanitisation methods and the organisation’s definition of “verification effectiveness” for each media type, and link them to the workflow’s verification step.


---

#### MP-6.2 — Equipment Testing (Enhancement)

This expectation is about showing that the tools and step-by-step instructions your organisation uses to wipe or destroy old storage media actually work as intended—not just that they are followed in theory. Without regular checks, there is a real risk that sensitive information could still be on devices after disposal or reuse. This could lead to data breaches, regulatory problems, financial loss, and reputational damage.

To meet this requirement, the organisation must test both its data-wiping equipment and its data-wiping procedures every quarter to confirm the intended result is achieved. Testing can be done internally or by a qualified and authorised external provider. The organisation must keep clear records of the test results for both the equipment and the procedures as evidence for audits, including any results provided by external testers. These records must be stored and kept in line with the organisation’s records retention rules so they can be reviewed later.

##### Quarterly sanitisation equipment & procedure testing with audit evidence

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish quarterly sanitisation testing scope and cadence (mp-6.2_prm_1), including in-scope device/procedure lists and testing frequency mapping | Compliance Manager | Enterprise | 16h | — |
| Create/refresh sanitisation equipment register and procedure library with authoritative identifiers and versioning (including approval status and linkage between procedures and devices) | Data Protection Officer | Enterprise | 24h | — |
| Define measurable verification criteria and pass/fail thresholds per sanitisation method (equipment run verification + procedure end-to-end verification) and publish as controlled test instructions | Security Engineer | Enterprise | 20h | — |
| Implement controlled quarterly test execution runbooks (roles, pre-checks, controlled test media/settings, post-verification, exception handling, and escalation) | Operations Lead | Department | 16h | — |
| Set up audit-evidence capture workflow in the evidence repository (GRC/DMS): evidence templates, required metadata (quarter, identifiers, settings, outcomes), access controls, and retention tagging | Project Manager | Enterprise | 24h | £6,000 |
| Perform first full quarterly cycle: execute equipment testing for all in-scope devices and procedure testing for all in-scope procedures using the exact current procedure versions; record dated, attributable, retrievable evidence | Service Delivery Manager | Department | 40h | — |
| If external testing is used: define/execute provider qualification and authorisation, and ensure external reports are stored with sufficient detail to evidence quarter/method/outcome | Compliance Manager | Enterprise | 12h | £3,500 |
| Conduct internal audit readiness review for the most recent quarter (evidence completeness, traceability to procedure versions, and remediation of any gaps) | Quality Assurance Lead | Enterprise | 16h | — |

**Total Estimated Effort:** 168h  
**Total Estimated Cost:** £9,500

###### Actions Required for Compliance

- [ ] Define and get approval for the quarterly testing scope for sanitisation equipment and procedures, aligned to **mp-6.2_prm_1**.
- [ ] Create clear, measurable pass-or-fail checks for every sanitisation method the organisation uses.
- [ ] Maintain a version-controlled library of sanitisation procedures and an equipment register that records each item using a unique device identifier.
- [ ] Run quarterly equipment tests using approved test media, and record the device settings, the verification results, and whether each test passed or failed.
- [ ] Run end-to-end tests of the procedure every quarter using the exact current version of the procedure, and record the supporting evidence and whether each test passed or failed.
- [ ] Store all test results in a controlled, auditable evidence repository, with rules for how long they are kept and how they can be retrieved.
- [ ] If you use an external tester, get authorisation and confirm they are suitably qualified. Then keep the external test reports, including the quarter, the testing method used, and the results.


---

#### MP-6.3 — Nondestructive Techniques (Enhancement)

This expectation is about making sure any removable storage device—such as a USB stick or external hard drive—is made safe before it is ever plugged into your systems. The real risk is that a device bought for the first time, or one whose past you cannot fully verify, could already contain harmful software. If it is connected too soon, that software could spread through your organisation, disrupt operations, steal information, or cause other damage.

To meet this expectation, the organisation must clearly define and document when sanitisation is required, including two situations:
- when devices are purchased from manufacturers or suppliers before first use, and
- when a complete, verifiable chain of custody cannot be maintained.

The organisation must also ensure that sanitisation is non-destructive (the device is cleaned and checked in a way that does not physically destroy it), that devices are not connected until the process is finished, and that named staff are responsible.

Finally, it must keep records showing:
- which device was treated,
- when it was treated,
- how it was treated,
- who carried it out, and
- evidence that the first connection happened only after sanitisation was completed.

##### Quarantine and sanitise-to-issue workflow for untrusted portable media

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and publish the `mp-06.03_odp` trigger-condition procedure (vendor-before-first-use and loss of chain-of-custody), including required device status outcomes and mapping to the control | Compliance Manager | Enterprise | 16h | — |
| Create the quarantine + gate operating model: locked access-controlled quarantine store requirements, labelling/status scheme, intake/issue workflow, and segregation of duties (quarantine vs sanitisation vs approval) | Operations Lead | Enterprise | 24h | — |
| Define approved non-destructive sanitisation methods by media type (USB/flash/external HDD, optical, magnetic/optical tapes) including required scan/verification steps, re-scan expectations, and evidence artefacts to retain | Cyber Security Lead | Enterprise | 32h | — |
| Implement auditable evidence capture and record structure (device unique ID, custody status, sanitisation method, start/end times, performer/approver, scan/wipe confirmation references) and integrate with existing ticketing/asset systems | Platform Engineer | Enterprise | 24h | £3,000 |
| Configure endpoint/MDM/EDR compensating controls to route/block unauthorised direct USB mass storage connections and enforce an exception workflow that requires sanitise-to-issue routing | DevOps Lead | Enterprise | 40h | £12,000 |
| Train Service Desk and sanitisation team on intake, quarantine handling, execution steps, and approval/sign-off requirements; include competency checks and run-throughs | Service Delivery Manager | Enterprise | 16h | — |
| Run pilot and perform control effectiveness validation (sample devices meeting trigger conditions; verify “no connection until completion”, evidence completeness, and bypass resistance), then update procedures based on findings | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 176h  
**Total Estimated Cost:** £15,000

###### Actions Required for Compliance

- [ ] In the media sanitisation procedure, document the MP-6(3) trigger conditions that are mapped to mp-06.03_odp.
- [ ] Set up a secure quarantine storage area and a clear device labelling system that prevents devices from being issued until sanitisation has been approved.
- [ ] Publish an approved list of non-destructive sanitisation methods by portable media type, and require staff to use only those methods.
- [ ] Create an information technology service management (ITSM) work-ticket template that requires: the device identifier, the method used, the relevant dates and times (timestamps), the person who carried out the task (performer), the person who approved it (approver), and supporting evidence attachments.
- [ ] Use a controlled “clean before use” approval step so devices cannot be connected until sanitisation sign-off has been recorded.
- [ ] Set up endpoint management/mobile device management (MDM)/endpoint detection and response (EDR) controls for USB access (or use an equivalent compensating control) to stop people from bypassing the “sanitise-to-issue” process.


---

#### MP-6.7 — Dual Authorization (Enhancement)

This requirement ensures that when valuable computer storage devices are wiped clean before they are disposed of, handed over, or reused, the wiping is independently approved and carried out by two properly trained and authorised people. This is important because if one person can do it alone, there is a higher risk of mistakes, incomplete wiping, or even false claims that the work was completed—leaving sensitive information exposed.

To meet this requirement, the organisation must clearly state which types of storage devices (such as solid-state drives, hard drives, removable drives, and storage arrays) must use the two-person approach. It must then use documented procedures so that wiping cannot begin, and cannot be signed off, without two separate approvals and two separate people carrying out the task.

The organisation must keep clear records showing who approved the wiping, what was wiped, and evidence that the process was followed. Where possible, it should rotate the pairings to reduce the chance that the same two people could collude.

##### Two-person workflow gate for dual-authorised system media sanitisation

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define mp-06.07_odp in-scope “system media” taxonomy and update sanitisation ticket form/template (asset identifiers, disposition, media type, required fields) | Compliance Manager | Enterprise | 16h | — |
| Design dual-authorization workflow states and gating rules (cannot reach “Ready to Execute” without two distinct, technically qualified approvers; enforce identity separation) | System Design Authority | Enterprise | 24h | — |
| Implement workflow logic in ITSM/Platform (e.g., JSM/ServiceNow): approval capture, identity binding, state transitions, and hard checks preventing same identity in multiple required roles | Platform Engineer | Enterprise | 40h | £6,000 |
| Implement two-person performance steps and verification evidence capture (identity-bound “Performed by” and “Second performer/verification”; method/tool/job logs attachments; checklist aligned to procedure) | Software Lead | Enterprise | 40h | £4,000 |
| Configure IAM/role-based access and competency/skills matrix enforcement for approvers and performers (including technical controls to prevent unqualified users; document rotation/pairing approach) | Data Protection Officer | Enterprise | 24h | £8,000 |
| Ensure auditability and retention: immutable status transition history, evidence link integrity, and audit export/reporting for media asset → approvals → execution → verification → completion | Security Engineer | Enterprise | 24h | £5,000 |
| Testing, pilot, and evidence-based acceptance (unit/workflow tests, negative tests for identity reuse, sample audit trail validation, and go-live readiness) | Quality Assurance Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 200h  
**Total Estimated Cost:** £23,000

###### Actions Required for Compliance

- [ ] Define which sanitisation media types are in scope for **mp-06.07_odp** in the workflow template, and require asset identifiers and disposal (disposition) fields.
- [ ] Set up the IT service management (ITSM) workflow so that “sanitisation” cannot move to “execution” unless there are two separate approvers, each with a different identity, and each decision is recorded with a timestamp.
- [ ] Implement workflow checks to prevent the same person (identity) from being used for both independent approval roles.
- [ ] Split the process into two required identity-checked steps: the first is done by the first person, and the second is done by a different person who verifies it. Do not allow the process to complete unless the two identities are different.
- [ ] Require and check supporting evidence and attachments for each asset, including erasure tool or job logs, verification results, and the relevant method-specific checklist.
- [ ] Limit what approvers and performers can do by using identity and access management (IAM) role mappings that are based on a maintained technical competency and skills matrix.
- [ ] Enable audit-ready record retention of workflow status changes and the evidence links for each completed sanitisation event


---

#### MP-6.8 — Remote Purging or Wiping of Information (Enhancement)

This requirement is about being able to remove company information from devices you no longer fully control, even from a distance. If a laptop, mobile phone, or cloud-managed server is lost, suspected to have been compromised, or an employee’s access is ended, there is a risk that sensitive data could be read or misused by unauthorised people.  

To meet this expectation, the organisation must provide a remote wipe or purge function for end-user laptops, mobile devices, and cloud-managed servers. This should allow wiping to be triggered when device control is lost, compromise is suspected, or access is terminated.  

Any remote wipe must only be allowed after strong identity checks, so unauthorised people cannot successfully request or approve a wipe. The organisation must also keep clear records showing who approved the wipe, when it was approved, which device or server was wiped, what action was taken, and whether the wipe completed successfully.

##### Identity-gated remote wipe for managed endpoints and servers

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define scope, wipe mechanisms per platform (MDM/UEM for endpoints; cloud server wipe/crypto-key destruction approach) and map to encryption-at-rest design | System Design Authority | Enterprise | 24h | — |
| Design authorised wipe workflow (conditions → human approval → execution → completion) including required audit fields and success/failure criteria | Compliance Manager | Enterprise | 16h | — |
| Implement RBAC/least-privilege for wipe approval/execution in MDM/UEM and cloud tooling; restrict console/API pathways to approved roles and constrained service principals | Security Engineer | Enterprise | 32h | — |
| Configure strong authentication/step-up for wipe approvals (phishing-resistant MFA where supported) and enforce step-up specifically for wipe actions | IAM Lead | Enterprise | 24h | — |
| Build/implement integration for audit logging: capture approving identity, timestamp, target identifier, triggering condition, wipe type, and status; forward to SIEM and align retention | SIEM/Logging Engineer | Enterprise | 24h | £3,000 |
| Develop and execute end-to-end test plan (non-production server workload + representative enrolled endpoints) including negative tests for unauthorised initiation/approval | Quality Assurance Lead | Enterprise | 24h | — |
| Produce audit-ready evidence pack (workflow screenshots/config exports, RBAC mappings, auth/step-up configuration evidence, SIEM log samples, test results) and handover to Operations for runbook updates | Project Manager | Enterprise | 16h | — |

**Total Estimated Effort:** 180h  
**Total Estimated Cost:** £3,000

###### Actions Required for Compliance

- [ ] Set up mobile device management (MDM), user experience management (UEM), and cloud tools so that devices in the defined endpoint and server categories can be remotely deleted or wiped.
- [ ] Set up an approval process so that device wipe requests are raised only when specific conditions are met: loss of device control, suspected compromise, or termination of access.
- [ ] Require phishing-resistant strong authentication and additional identity checks (step-up authentication) before approving and carrying out a device wipe in the management console and in any connected application programming interfaces (APIs).
- [ ] Apply least-privilege role-based access control (RBAC) by creating a dedicated “wipe approver” role and limiting wipe permissions to that role only.
- [ ] For every wipe, enable and export audit logs to the security information and event management (SIEM) system, including: who approved it, the date and time, the identifier of the target, the condition, the type of action, and the result.
- [ ] Carry out controlled test wipes and negative tests to confirm that unauthorised accounts cannot start or approve wipes, and that wipe completion is verified.


---

### MP-7 — Media Use (Control)

This requirement is about preventing people from connecting their own memory sticks, external drives, or other removable storage to systems that store Confidential or Secret information, unless the organisation has explicitly approved that device. If this is not controlled, a lost or unapproved device could be used to copy sensitive information, install harmful software, or make it difficult to identify who is responsible for any resulting problems.

To meet this expectation, the organisation must ban personally owned removable media on all systems and components that handle Confidential or Secret information, unless the device is registered and approved. The organisation must enforce this by blocking unauthorised removable-device connections and disabling both reading from and writing to any non-approved devices.

The organisation must also prohibit any portable storage device that does not have an identifiable owner.

Finally, the organisation should document the rules for using removable media, set clear expectations for user behaviour, record the technical settings used to enforce the restrictions, keep audit evidence showing enforcement actions, and assign clear responsibilities to the appropriate staff, including system and network administrators.

##### Enforce approved removable media only for Confidential/Secret systems

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define MP-7 removable media rule set (allowed/prohibited media types, identifiable owner requirement, environment scope, exception/recertification model) | Compliance Manager | Enterprise | 24h | — |
| Identify and confirm covered systems/components (Confidential/Secret scope mapping, endpoint/server inventory, data-flow justification, change impact assessment) | System Design Authority | Enterprise | 32h | — |
| Select and design enforcement approach (device registration mechanism, port/connection blocking strategy, read/write disable policy, default-deny behaviour) | Security Engineer | Enterprise | 24h | — |
| Implement technical enforcement on endpoints/servers (USB/mass-storage class blocking, removable storage detection, disable read/write for non-approved devices, allow only registered devices) | Platform Engineer | Enterprise | 80h | — |
| Build/operate approved removable media registry (device identifiers, owner mapping, approval scope/expiry, workflow integration with IT Ops/Service Desk) | Operations Lead | Enterprise | 40h | — |
| Integrate enforcement telemetry with SIEM (log schema, event routing, alerting thresholds for repeated blocked attempts, policy/version tagging, retention alignment) | DevOps Lead | Enterprise | 32h | — |
| Pilot and validate (register at least one approved device, test denial of unregistered/no-owner devices, produce evidence pack for audit readiness, remediate gaps) | Quality Assurance Lead | Enterprise | 24h | £6,000 |
| Create operational runbooks and governance evidence (registration SOP, exception handling, periodic access review, incident/rollback procedures, training for Service Desk/System Owners) | Project Manager | Enterprise | 24h | — |

**Total Estimated Effort:** 280h  
**Total Estimated Cost:** £6,000

###### Actions Required for Compliance

- [ ] Define and publish MP-7 rules for using media on Confidential and Secret systems. The rules must list which media types are not allowed and which media are allowed only when they are registered and approved.
- [ ] Create an approved register for removable media that records the device identifier, the identifiable owner, the approved scope of use, and the expiry date and recertification date.
- [ ] Set a default “deny” rule for removable media on covered devices and servers (block unauthorised connections from USB drives and other external storage).
- [ ] Put controls in place to block any removable storage devices that are not approved, so that on covered systems they cannot be used to read or write data.
- [ ] Link enforcement events to security information and event management (SIEM) and keep audit records that show the device identifier, the connection attempt, and the enforcement result.
- [ ] Run a pilot: register one approved device and confirm it works, while an unregistered or personal device is blocked and cannot read or write.


---

#### MP-7.2 — Prohibit Use of Sanitization-resistant Media (Enhancement)

This requirement is about stopping staff from using certain “hard-to-wipe” storage devices in company systems. Even after a device is cleared, it can still leave information behind. If this is not prevented, someone who later gets the device could recover sensitive business data, creating a serious risk of data leaks, regulatory issues, and reputational damage.

To meet this expectation, the organisation must clearly define and document which types of storage it treats as not reliably sanitised. This includes compact flash, embedded flash, solid-state drives, and USB removable media. The organisation must keep this list up to date so staff can recognise the prohibited types.

The organisation must then include a clear ban in its rules for using media and in staff guidance, assign clear responsibility for following the rules, and ensure that system settings and enforcement controls prevent these storage types from being used on relevant systems.

The organisation must also keep evidence of these restrictions in its policies, procedures, and system documentation. It must be able to show that staff understand what to do and that systems actually block the prohibited devices in practice.

##### Enforce ban on sanitisation-resistant media via media catalogue

- Category: Manual
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define and publish the single authoritative “Sanitisation-resistant Media Prohibited Catalogue” (including CF, embedded flash, SSDs, USB removable media) with explicit prohibited labels and scope boundaries | Compliance Manager | Enterprise | 16h | — |
| Create recognition guidance for each prohibited category (markings, form factors, embedded flash module scenarios, examples) and produce a staff-facing quick reference | Security Engineer | Enterprise | 12h | — |
| Update media-use policy and supporting procedures to implement a hard ban (not “discourage”), referencing the catalogue categories and requiring approved alternatives for any storage media needs | Compliance Manager | Enterprise | 14h | — |
| Produce audit-ready governance artefacts: version-controlled catalogue record, ownership/RACI, change-control workflow, and evidence retention requirements | Data Protection Officer | Enterprise | 10h | — |
| Integrate catalogue enforcement into service management workflows: update ticket/request templates, mandatory selection/confirmation against catalogue (no free-text bypass), and approver checklist | Service Delivery Manager | Enterprise | 18h | — |
| Create OT-adjacent technician/work-order instructions and acceptance checks to prevent insertion/installation of prohibited media during relevant maintenance activities (engineering workstations, HMI/SCADA support contexts) | Operations Lead | Department | 16h | — |
| Generate and validate audit evidence pack for MP-7(2): catalogue version, policy/procedure text, workflow template screenshots/exports, and change-control records; run a tabletop audit rehearsal | Project Manager | Enterprise | 12h | — |

**Total Estimated Effort:** 98h  
**Total Estimated Cost:** £0

###### Actions Required for Compliance

- [ ] Define and publish a version-controlled “Media Catalogue” that lists compact flash, embedded flash, solid-state drives (SSDs), and USB removable media as prohibited because they are resistant to sanitisation.
- [ ] Update the organisation’s media-use policy and procedures to strictly prohibit any prohibited media types, and refer to the Media Catalogue.
- [ ] Add recognition guidance (device shape and marking examples) to the Media Catalogue to help staff identify items correctly.
- [ ] Update the service request and work-order templates so that media type selection and approval are controlled by the Media Catalogue.
- [ ] Assign named owners for catalogue governance and for keeping workflow enforcement evidence in place (information technology (IT) infrastructure or endpoint lead, and operational technology (OT) maintenance lead where applicable).
- [ ] Create audit-ready evidence packs, including the latest versions of policies and procedures, catalogue versions, screenshots or exports of workflow templates, and change-control records.


---

### MP-8 — Media Downgrading (Control)

This expectation is about making sure that before we send data outside the organisation or reuse equipment, we first remove or reduce what remains on storage. This prevents sensitive information from being recovered by the next user. Without this, confidential or secret information could be unintentionally exposed, rebuilt, or read from old drives, exported files, or other media. That could cause financial, legal, and reputational harm.

To meet this expectation, the organisation must use a documented, proven process to reduce and clean storage in a way that matches the sensitivity of the information being removed. The process must use the strongest appropriate method (including making encrypted data unreadable where feasible) and must keep evidence showing the work was checked and completed.

The organisation must:
- identify every removable memory, every solid-state drive (SSD) and hard disk drive (HDD), and every exported dataset leaving the organisation that contains Confidential or Secret information
- verify that the level of cleaning is suitable for the person or organisation receiving it
- carry out the cleaning using the documented process
- keep item-by-item records showing what was done, when, by whom, and that it was verified before anything is released

##### Automated media downgrading workflow with crypto-erase and evidence

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Define and operationalise classification-to-downgrading method mapping (Confidential vs Secret), including crypto-erase feasibility rules, fallback hierarchy, and required verification artefacts | Compliance Manager | Enterprise | 24h | — |
| Standardise encryption-at-rest controls for storage volumes/datasets used for external release (key management requirements, rotation/disable semantics, and crypto-erase prerequisites) | Security Engineer | Enterprise | 32h | — |
| Design the end-to-end automated downgrading workflow (trigger points, input schema, method selection logic, recipient suitability gating, evidence bundle model, and audit trail requirements) | System Design Authority | Enterprise | 40h | — |
| Implement workflow orchestration and integrations (release/export event trigger, asset/dataset identification, method execution hooks, evidence capture, and exception handling) | Platform Engineer | Enterprise | 72h | — |
| Integrate with sanitisation/crypto-erase tooling and key management APIs (drive/media sanitisation where applicable; key invalidation/secure key destruction where feasible; capture tool outputs) | DevOps Lead | Enterprise | 56h | £18,000 |
| Implement recipient authorisation/entitlement checks and block external release on mismatch (including target release level validation and audit logging) | IAM/Access Management Owner | Enterprise | 24h | — |
| Build evidence bundle generation, retention, and retrieval (item-specific evidence, linkage to release/shipment/export records, tamper-evident storage, and audit-ready access) | Operations Lead | Enterprise | 32h | £6,000 |
| Perform end-to-end testing, pilot rollout, and operational readiness (test plans, runbooks, monitoring/alerting for workflow failures, and evidence verification validation) | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 320h  
**Total Estimated Cost:** £24,000

###### Actions Required for Compliance

- [ ] Define the rules for downgrading information from **Confidential** to **Secret**, including where possible and required, secure deletion of the encryption keys and the verification steps needed to confirm it has been done correctly.
- [ ] Standardise encryption for data stored on storage volumes and datasets, so that crypto-erase (making the data unreadable by destroying the encryption key) is possible for eligible media.
- [ ] Set up an automated process that starts when qualifying assets or exports are released externally, and then chooses the correct downgrading method based on their classification.
- [ ] Add a check that confirms the recipient is authorised for the intended release level, and block the release if they are not.
- [ ] Where possible, carry out “crypto-erase” (making the encryption key unusable and securely destroying it). If this is not possible, use the defined stronger method instead.
- [ ] Record and store item-specific proof of verification (the method used, the results, and who carried out and approved it, with dates and times), and link it to the external release record.


---

#### MP-8.1 — Documentation of Process (Enhancement)

This requirement ensures that whenever the organisation lowers the protection level for stored devices or media, it keeps a clear record of what was changed. Without this, downgraded media could be handled incorrectly, used for the wrong purpose, or altered without proper permission—raising the risk that sensitive information ends up with the wrong people.

To meet this expectation, the organisation must record every action to downgrade media, including:
- the method used,
- the unique identification number of the specific item downgraded, and
- the identity of the person who authorised and/or carried out the change.

These records must be kept as part of the organisation’s media protection procedures and the system’s security documentation. The organisation must also maintain an up-to-date list of which media needs downgrading, so each action can be matched to the correct item.

The organisation should also ensure that relevant audit information is retained, and that the roles responsible for documenting, authorising, and carrying out downgrades are clearly defined.

##### Media Downgrade Register with method, media ID, and authorisation

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---|---:|---:|
| Define media downgrade register data model (fields, constraints, approved downgrade methods list, separation-of-duties rules, environment/system references, reason/trigger mapping) and publish as controlled specification | Compliance Manager | Enterprise | 16h | — |
| Implement/extend authoritative media inventory with unique media identifiers and eligibility status flag (“requires downgrading” vs “not eligible”), including data import/migration from existing sources | Infrastructure Lead | Enterprise | 40h | £8,000 |
| Configure workflow-backed register in ITSM/GRC (single supported mechanism) with mandatory fields, constrained dropdowns for downgrade method, and validation logic for media ID existence and eligibility state | DevOps Lead | Enterprise | 32h | £6,000 |
| Implement separation-of-duties enforcement (authoriser ≠ performer where required; otherwise record same-person explicitly per policy) and capture timestamp(s) and system/environment reference automatically | Security Engineer | Enterprise | 24h | — |
| Configure controlled record storage and retention (document management/GRC retention policy), including access controls and linkage from media protection procedures and system security documentation | Data Protection Officer | Enterprise | 20h | £3,000 |
| Ensure audit trail retention and evidence production (workflow event history, approvals, completion logs) with an audit-ready query/report pack for MP-8(1) evidence | Quality Assurance Lead | Enterprise | 18h | — |
| Conduct end-to-end testing and operational readiness (test cases for valid/invalid media IDs, ineligible states, missing mandatory identities, separation-of-duties outcomes; runbook + admin guidance) | Project Manager | Enterprise | 24h | £2,500 |
| Rollout, training, and go-live governance (pilot, user training for authorisers/performers/custodians, monitoring of workflow failures, and post go-live review) | Service Delivery Manager | Enterprise | 16h | £1,500 |

**Total Estimated Effort:** 210h  
**Total Estimated Cost:** £23,000

###### Actions Required for Compliance

- [ ] Set out the required information that must be recorded in the Media Downgrade Register, including: method or technique, media identifier, identity of the person who authorises it, identity of the person who performs it, date and time, and the system reference.
- [ ] Create or update the official media inventory, ensuring each item has a unique identifier and a flag that shows whether it is eligible for downgrading.
- [ ] Set up a workflow-based register (IT service management (ITSM) / governance, risk management and compliance (GRC)) to check media IDs against the inventory, and prevent submissions for items that are not eligible.
- [ ] Where required, make sure different people handle different steps in the workflow (separation of duties), and ensure any cases where the same person is involved are handled according to the organisation’s media protection procedure.
- [ ] Set up rules for how long register records and link entries are kept, and who can access them, and link them to the media protection procedures and system security documentation.
- [ ] Check that the audit trail is kept for the required period, and provide a sample evidence pack that includes the full downgrade record from submission through approval and completion.


---

#### MP-8.2 — Equipment Testing (Enhancement)

This requirement is about making sure the tools and step-by-step instructions your organisation uses to lower the security level of stored media work properly in real life—not just in documents. If checks are not carried out regularly, media that has been downgraded could end up with a higher security level than expected (leading to delays and extra cost), or—more seriously—with the wrong level of protection (leaving sensitive information exposed).

To meet this expectation, the organisation must test both the downgrading equipment and the downgrading procedures at least once every quarter. Each time, the organisation must confirm that the media is downgraded to the expected lower security state.

The organisation must also keep clear records showing what was tested, the result of each equipment and procedure test, and details of any media downgrading activities carried out. This allows an auditor to verify that the quarterly testing matches what actually happens when media is downgraded.

##### Quarterly test harness for media downgrading equipment & procedures

- Category: Software
- Priority: High

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Establish isolated quarterly downgrading test harness environment (network segmentation, access controls, logging enabled, separation from production) | Infrastructure Lead | Enterprise | 40h | £8,000 |
| Create/maintain registers for approved downgrading equipment and approved downgrading procedures (including versioning, effective dates, and linkage keys) | Compliance Manager | Enterprise | 24h | — |
| Implement standard quarterly test script/workflow (prepare representative media, execute downgrading using approved equipment, verify expected lower security state) | Software Lead | Enterprise | 56h | £3,500 |
| Define objective verification method and pass/fail criteria (tool/state/cryptographic checks as applicable) and integrate into the test script outputs | Security Engineer | Enterprise | 32h | — |
| Configure automated evidence capture and tamper-evident retention (immutable/WORM or signed reports; include identifiers, results, and audit metadata) | Data Protection Officer | Enterprise | 40h | £6,000 |
| Integrate quarterly test execution into change/release governance (calendar trigger, approval gates, authorised execution controls, and audit trail linking test to operational identifiers) | Project Manager | Enterprise | 28h | — |
| Run initial pilot (first quarterly cycle dry-run), remediate gaps, and produce an audit-ready evidence pack template for subsequent quarters | Quality Assurance Lead | Enterprise | 24h | — |

**Total Estimated Effort:** 244h  
**Total Estimated Cost:** £17,500

###### Actions Required for Compliance

- [ ] Define and document the expected checks to confirm a lower security state before downgrading media.
- [ ] Set up a controlled quarterly test to reduce media quality, using only approved equipment and the approved versions of the test procedure.
- [ ] Create and keep up-to-date records of equipment and procedures, including unique identifiers and version numbers.
- [ ] Set up automated evidence collection for every quarterly test run, including the equipment ID, the procedure version, the media identifiers, the verification results, and whether the test passed or failed.
- [ ] Schedule quarterly execution with role-based access control (RBAC) and approval checkpoints
- [ ] Store test evidence in an unchangeable, tamper-evident repository and keep it for the required period so audits can trace what happened.
- [ ] Update the operational downgrading process so it records the same equipment and procedure identifiers as those used in the quarterly tests.


---

#### MP-8.3 — Controlled Unclassified Information (Enhancement)

This requirement is about making sure that any storage device or other media holding sensitive information that is not for public release is properly “downgraded” before it leaves the organisation. Without this, confidential material could be accidentally published or given to the public, which could cause legal, financial, and reputational harm.

To meet this expectation, the organisation must first identify which media items contain Controlled Unclassified Information, then downgrade those items before any public release using only approved methods and tools, following its written and documented procedures. The organisation must also involve the correct responsible staff and information security reviewers as required, keep clear records of what was done (including which approved method was used, who carried it out, and when it was completed), and ensure the records are detailed enough to be checked later.

Finally, the organisation must document its approach in system-level planning so the process can be repeated and consistently followed.

##### Approved CUI media downgrading workflow with release gate

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design the end-to-end MP-8(3) release gate workflow (media register → sanitisation record → release-to-public block) including state model, required fields, and audit evidence mapping | System Design Authority | Enterprise | 24h | — |
| Implement/extend the CUI media register in operational tooling (e.g., ITSM/CMDB) with media identifiers, CUI flag, environment, ownership, and linkage to sanitisation records | Platform Engineer | Enterprise | 40h | — |
| Build the approved sanitisation catalogue and enforce catalogue-only selections in the workflow (tool/technique/media-type constraints + required verification method + required evidence fields) | Security Engineer | Enterprise | 32h | — |
| Develop the workflow engine integration for hard gates on release-to-public events (export, shipment, external handover, public dataset publication) with technical enforcement where feasible | Software Lead | Enterprise | 56h | — |
| Implement role-based authorisation and procedure adherence controls (RBAC for sanitisation initiation + security review sign-off; restrict execution to approved stations/tools per technique) | Cyber Security Lead | Enterprise | 32h | — |
| Create tamper-evident/append-only evidence capture for sanitisation verification outputs (operator identity, timestamps, tool outputs, technique identifiers, checksums/artefacts) and ensure audit retrieval by media identifier | Security Engineer | Enterprise | 40h | £6,000 |
| Integrate monitoring/alerting and release exception handling (alert if release-to-public occurs without completed sanitisation evidence for all CUI media; define escalation and remediation runbook) | Operations Lead | Enterprise | 24h | £3,000 |
| Test, security review, and pilot rollout (unit/integration tests, gate bypass resistance, audit evidence validation, operator training, and go-live readiness) | Quality Assurance Lead | Enterprise | 40h | — |

**Total Estimated Effort:** 288h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Create and fill a Controlled Unclassified Information (CUI) media register with unique media identifiers and a CUI status flag.
- [ ] Publish an approved sanitisation catalogue covering: the tool to use, the sanitisation technique, any limits on the media type, how sanitisation will be verified, and the required evidence fields.
- [ ] Set up a process that stops any release to the public unless a completed sanitisation record is linked to the specific media identifiers.
- [ ] Set up role-based access control (RBAC) so that only authorised people can start sanitisation and approve the security review sign-off
- [ ] Set up sanitisation to run automatically while also recording the tool results, the operator’s identity, the date and time, and the proof files in tamper-evident storage.
- [ ] Set up monitoring rules to alert (and, where possible, stop) any release to the public that does not have linked, completed downgrading evidence for controlled unclassified information (CUI) media.


---

#### MP-8.4 — Classified Information (Enhancement)

This requirement is about making sure that any storage device or removable media that contains sensitive, officially classified information is made safe before it leaves the organisation. If this is not done, a disk, drive, tape, or memory card could be given to someone who is not allowed to see that information, which could result in unauthorised disclosure, regulatory breaches, and serious harm to people and operations.

To meet this requirement, the organisation must first identify which media contains classified information and check whether the intended recipient has the required permission. If they do not, the organisation must reduce the classified information to unclassified status before it is released, using only approved, documented methods and tools, and ensuring that only information confirmed as unclassified is transferred.

The organisation must also keep clear, auditable records showing which media was processed, when it was processed, who processed it, what approved method was used, and the verified unclassified result. Finally, it must have up-to-date policies and procedures, named responsible staff, and training so the process is carried out consistently.

##### Authorisation-gated media release workflow with approved downgrading

- Category: Software
- Priority: Critical

| Task / Deliverable | Owner Role | Org Level | Effort (Hours) | Cost (GBP) |
|---|---|---:|---:|---:|
| Design the authorisation-gated media release workflow (state model, gating rules, error paths, and audit record schema) | System Design Authority | Enterprise | 24h | — |
| Implement authoritative media register integration (CRUD, classification/level fields, location, release history, immutability controls, and API/events for workflow) | Platform Engineer | Enterprise | 40h | — |
| Integrate pre-release recipient authorisation check with identity/authorisation service (RBAC/ABAC evaluation, policy mapping to classification levels, and decision logging) | Security Engineer | Enterprise | 32h | — |
| Build release gating enforcement in application workflow (block hand-over unless authorised OR approved downgrading completed with verified evidence; include attempted-release logging) | Software Lead | Enterprise | 32h | — |
| Implement approved downgrading orchestration (sanitisation work order generation, restricted execution/approval by sanitisation roles, tool/technique/procedure ID + version capture, operator identity, and workflow transitions) | DevOps Lead | Enterprise | 48h | £6,000 |
| Implement verification and evidence capture (attach tool/scan reports or independent sign-off evidence to media release record; enforce “no evidence, no release” rule) | Quality Assurance Lead | Enterprise | 24h | — |
| Configure auditability and retention (SIEM/event hooks, tamper-evident storage approach, audit dashboards, and evidence export for audits) | Compliance Manager | Enterprise | 24h | £3,000 |
| Security testing & assurance (unit/integration tests for gating, authorisation edge cases, downgrade/verification negative tests, and security review of workflow) | Cyber Security Lead | Enterprise | 32h | — |

**Total Estimated Effort:** 256h  
**Total Estimated Cost:** £9,000

###### Actions Required for Compliance

- [ ] Create, approve, and publish a catalogue of sanitisation tools, techniques, and procedures. Assign each procedure an ID and state the required proof (verification evidence) that it has been carried out.
- [ ] Set up an official media register to record each media item’s identifier, its classification status, and its release history.
- [ ] Set up an authorisation-controlled media release process that prevents hand-over unless the recipient’s authorisation has been confirmed or the downgrade process has been completed.
- [ ] Integrate the workflow with the organisation’s identity and access authorisation service to check whether each recipient is authorised to receive content at the specified media classification level.
- [ ] Set up sanitisation work orders so only authorised roles can carry out and approve the approved downgrade methods, and so the system records the tool version and the operator’s identity.
- [ ] Capture verification evidence and attach it to the media release record, so that only confirmed unclassified results are allowed to be released.
- [ ] For every media release event, enable audit logging and keep the supporting evidence. Record: media ID, recipient, the authorisation decision, the method used to downgrade, the verification result, the approver, and the time and date (timestamp).

